using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ResoniteBindingGenerator
{
    public string BINDINGS_ROOT_PATH => Path.Combine("Assets", "ResoniteSDK", "Bindings", "Generated");

    readonly ResoniteLink.LinkInterface link;

    Dictionary<string, ComponentDefinition> _componentDefinitionCache = new Dictionary<string, ComponentDefinition>();
    HashSet<string> _generatedComponents = new HashSet<string>();
    HashSet<string> _generatedDummyTypes = new HashSet<string>();

    public ResoniteBindingGenerator(ResoniteLink.LinkInterface link)
    {
        this.link = link;
    }

    public async Task GenerateBindings()
    {
        // Start generating bindings from the root category. This will work downwards recursively, covering all the component types
        await GenerateComponentBindings("");
    }

    async Task GenerateComponentBindings(string categoryPath)
    {
        var list = await link.GetComponentTypes(categoryPath);

        // This should never fail unless something went really wrong or we messed up
        if (!list.Success)
            throw new System.Exception($"Failed to fetch component list: {list.ErrorInfo}");

        if (list.ComponentTypes != null)
            foreach (var type in list.ComponentTypes)
                await GenerateComponentBinding(type);

        // If there are subcategories, generate bindings for are those!
        if (list.SubCategories != null)
            foreach (var subCategory in list.SubCategories)
                await GenerateComponentBindings(categoryPath + "/" + subCategory);
    }

    async Task GenerateComponentBinding(string type)
    {
        // Only generate bindings once for the same type. There are two cases when components can be encountered twice:
        // - Components can be categorized into multiple categories at the same time
        // - Base types are shared across multiple components
        if (!_generatedComponents.Add(type))
            return;

        var definition = await GetComponentDefinition(type);

        // Figure out the file path for the file
        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, definition.CategoryPath ?? "Uncategorized");
        var filePath = Path.Combine(directoryPath, definition.Type.Name + ".cs");
        var source = await GenerateBindingSource(definition);

        Debug.Log($"Writing bindings file: {filePath}");

        Directory.CreateDirectory(directoryPath);
        File.WriteAllText(filePath, source);

        // Ensure that all the base types are processed and we have files for those as well
        if (definition.Type.BaseType != null)
            await GenerateComponentBinding(definition.Type.BaseType.Type);
    }

    async Task GenerateDummyBinding(TypeDefinition type)
    {
        if (!_generatedDummyTypes.Add(type.FullTypeName))
            return;

        var code = await GenerateDummySource(type);

        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, "DummyTypes");
        var filePath = Path.Combine(directoryPath, type.Namespace + "." + type.Name + ".cs");

        Debug.Log($"Writing bindings file: {filePath}");

        Directory.CreateDirectory(directoryPath);
        File.WriteAllText(filePath, code);
    }

    async Task<string> FullyQualifyType(TypeDefinition type, List<string> genericArguments, List<GenericParameter> rootGenericParameters)
    {
        // If the type isn't a component, we need to generate a dummy file for it so it can be referenced. It'll contain no actual code.
        if (!type.IsComponent)
            await GenerateDummyBinding(type);

        var typeName = "global::" + type.Namespace + "." + type.Name;

        if (type.IsGenericType)
        {
            // Remove the back tick
            typeName = typeName.Substring(0, typeName.IndexOf('`'));

            // Include all the generic arguments
            var args = new string[genericArguments.Count];

            for (int i = 0; i < args.Length; i++)
            {
                var arg = genericArguments[i];

                // If it's a generic parameter, just pass it through as is
                if (rootGenericParameters?.Any(p => p.Name == arg) ?? false)
                    args[i] = arg;
                else
                {
                    // Recursively resolve the type definition
                    var argDefinition = await link.GetTypeDefinition(arg);

                    if (!argDefinition.Success)
                        throw new System.Exception($"Failed to fetch arg definition: {argDefinition.ErrorInfo}");

                    args[i] = await FullyQualifyType(argDefinition.Definition, argDefinition.Definition.GenericArguments, rootGenericParameters);
                }
            }

            typeName += $"<{string.Join(",", args)}>";
        }

        return typeName;
    }

    async Task<string> GenerateDummySource(TypeDefinition type)
    {
        return await GenerateBindingSource(type, "// Dummy class, there's no body", "UnityEngine.Object");
    }

    async Task<string> GenerateDeclaration(TypeDefinition type, string defaultBaseDefinition)
    {
        // Determine the name of the class
        var classDef = type.Name;

        if (type.IsGenericType)
        {
            // Remove the back-tick from the name
            classDef = classDef.Substring(0, classDef.IndexOf('`'));

            // Add the generic parameters
            classDef += $"<{string.Join(",", type.GenericParameters.Select(p => p.Name))}>";
        }

        // Determine the base class name
        string baseDef;

        if (type.BaseType == null)
            baseDef = defaultBaseDefinition;
        else
        {
            var baseDefinitionResult = await link.GetTypeDefinition(type.BaseType.Type);

            if (!baseDefinitionResult.Success)
                throw new System.Exception($"Exception getting base type: {baseDefinitionResult.ErrorInfo}");

            baseDef = await FullyQualifyType(baseDefinitionResult.Definition, type.BaseType.GenericArguments, type.GenericParameters);
        }

        var str = new StringBuilder();
        str.AppendLine($"public {(type.IsAbstract ? "abstract" : "")} {(type.IsInterface ? "interface" : "class")} {classDef} : {baseDef}");

        // TODO!!! Generic constraints & Interfaces

        return str.ToString();
    }

    async Task<string> GenerateBindingSource(TypeDefinition type, string body, string defaultBaseClass)
    {
        var declaration = await GenerateDeclaration(type, defaultBaseClass);

        return $@"
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated on: {System.DateTime.UtcNow.ToLongDateString()} - {System.DateTime.UtcNow.ToLongTimeString()}
// -----------------------------------------------------------------------------

using UnityEngine;

namespace {type.Namespace}
{{
    {declaration}
    {{
        {body}
    }}
}}
";
    }
    
    async Task<string> GenerateBindingSource(ComponentDefinition definition)
    {
        return await GenerateBindingSource(definition.Type, "", "UnityEngine.MonoBehaviour");
    }

    async ValueTask<ComponentDefinition> GetComponentDefinition(string type)
    {
        if (_componentDefinitionCache.TryGetValue(type, out var definition))
            return definition;

        // We specifically fetch un-flattened component definitions.
        // We will work our way upwards the types to mimic the inheritance hierarchy.
        var definitionResult = await link.GetComponentDefinition(type, false);

        if (!definitionResult.Success)
            throw new System.Exception($"Failed to fetch component definition for type {type}:\n{definitionResult.ErrorInfo}");

        definition = definitionResult.Definition;

        // Store it in the cache before returning it
        _componentDefinitionCache.Add(type, definition);

        return definition;
    }
}
