using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ResoniteBindingGenerator
{


    public string BINDINGS_ROOT_PATH => Path.Combine("Assets", "ResoniteSDK", "Bindings", "Generated");

    readonly ResoniteLink.LinkInterface link;
    readonly ProgressSynchronizer progress;
    readonly CancellationToken cancellationToken;

    Dictionary<string, ComponentDefinition> _componentDefinitionCache = new Dictionary<string, ComponentDefinition>();
    HashSet<string> _generatedTypes = new HashSet<string>();

    public ResoniteBindingGenerator(ResoniteLink.LinkInterface link, CancellationToken cancellationToken, ProgressSynchronizer progress = null)
    {
        this.link = link;
        this.progress = progress;
        this.cancellationToken = cancellationToken;
    }

    public async Task GenerateBindings()
    {
        try
        {
            progress?.UpdateProgress("Starting generation", 0f);

            // Delete previous bindings, since we'll regenerate everything
            if (Directory.Exists(BINDINGS_ROOT_PATH))
            {
                progress?.UpdateProgress("Deleting old bindings", 0f);
                Directory.Delete(BINDINGS_ROOT_PATH, true);
            }

            // Start generating bindings from the root category. This will work downwards recursively, covering all the component types
            await GenerateComponentBindingsForCategory("");
        }
        catch(System.Exception ex)
        {
            Debug.LogError($"Exception when generating bindings:\n{ex}");
        }
        finally
        {
            progress?.Complete();
        }
    }

    void CheckCancellation()
    {
        if (cancellationToken.IsCancellationRequested)
            throw new TaskCanceledException();
    }

    public async Task GenerateComponentBindingsForCategory(string categoryPath)
    {
        CheckCancellation();

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
                await GenerateComponentBindingsForCategory(categoryPath + "/" + subCategory);
    }

    async Task<string> GenerateFilePath(string directory, TypeDefinition type)
    {
        var name = await GenerateRawFileName(type);

        name += ".cs";

        var path = Path.Combine(directory, name);

        // Make sure we're not overwriting existing files - they should be deleted before hand
        // This makes sure there's no file-name collisions
        if (File.Exists(path))
            throw new System.Exception($"File for {type.FullTypeName} already exists: {path}");

        return path;
    }

    async Task<string> GenerateRawFileName(TypeDefinition type)
    {
        string name;

        if (type.IsNested)
        {
            var result = await link.GetTypeDefinition(type.DeclaringType);

            if (!result.Success)
                throw new System.Exception($"Failed to get declaring type for type {type.FullTypeName}: {result.ErrorInfo}");

            name = await GenerateRawFileName(result.Definition);
        }
        else
            name = type.Namespace;

        name += "." + type.Name;

        if (type.DirectGenericParameterCount > 0)
            name += $"`{type.DirectGenericParameterCount}";

        return name;
    }

    public async Task GenerateComponentBinding(string type)
    {
        CheckCancellation();

        // Only generate bindings once for the same type. There are two cases when components can be encountered twice:
        // - Components can be categorized into multiple categories at the same time
        // - Base types are shared across multiple components
        if (!_generatedTypes.Add(type))
            return;

        var definition = await GetComponentDefinition(type);

        if(definition.Type.IsGenericType && !definition.Type.IsGenericTypeDefinition)
        {
            // This is a generic type instance! We must get the generic type definition in order to be able to generate the binding
            var result = await link.GetGenericTypeDefinition(type);

            if (!result.Success)
                throw new System.Exception($"Failed to get generic type definition for type {type}: {result.ErrorInfo}");

            // Check again - it's possible we generated this component already
            if (!_generatedTypes.Add(result.Definition.FullTypeName))
                return;

            // Get the definition for the generic type definition
            definition = await GetComponentDefinition(result.Definition.FullTypeName);
        }

        progress?.UpdateProgress(definition.Type.FullTypeName, 0f);

        var source = await GenerateBindingSource(definition);

        // Figure out the file path for the file
        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, definition.CategoryPath ?? "Uncategorized");
        var filePath = await GenerateFilePath(directoryPath, definition.Type);

        Directory.CreateDirectory(directoryPath);

        File.WriteAllText(filePath, source);

        // Ensure that all the base types are processed and we have files for those as well
        if (definition.Type.BaseType != null)
            await GenerateComponentBinding(definition.Type.BaseType.Type);
    }

    public async Task GenerateEnumBinding(TypeDefinition type)
    {
        if (!_generatedTypes.Add(type.FullTypeName))
            return;

        var result = await link.GetEnumDefinition(type.FullTypeName);

        if (!result.Success)
            throw new System.Exception($"Failed to fetch enum definition for {type.FullTypeName}: {result.ErrorInfo}");

        var enumDefinition = result.Definition;

        var body = new StringBuilder();

        foreach (var entry in enumDefinition.Values)
            body.AppendLine($"{entry.Key} = {entry.Value},");

        var source = await GenerateBindingSource(type, body.ToString(), enumDefinition.IsFlags ? "[Flags]" : "", enumDefinition.BackingType);

        // Figure out the file path for the file
        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, "Enums", type.AssemblyName);
        var filePath = await GenerateFilePath(directoryPath, type);

        Directory.CreateDirectory(directoryPath);

        File.WriteAllText(filePath, source);
    }

    async Task GenerateDummyBinding(TypeDefinition type, string dependencyType)
    {
        CheckCancellation();

        // Do not generate dummy bindings for any of the system types
        if (type.AssemblyName.StartsWith("System"))
            return;

        if (!_generatedTypes.Add(type.FullTypeName))
            return;

        progress?.UpdateProgress(type.FullTypeName, 0f);

        if (type.IsGenericType && !type.IsGenericTypeDefinition)
        {
            // Resolve the generic type definition for this type
            var result = await link.GetGenericTypeDefinition(type.FullTypeName);

            if (!result.Success)
                throw new System.Exception($"Failed to resolve generic type definition for {type.FullTypeName}: {result.ErrorInfo}");

            type = result.Definition;

            // We need to check again, because it's possible a different generic instance type of the same generic type
            // was already processed. Avoid generating twice
            if (!_generatedTypes.Add(type.FullTypeName))
                return;
        }

        var code = await GenerateDummySource(type, dependencyType);

        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, "DummyTypes", type.AssemblyName);
        var filePath = await GenerateFilePath(directoryPath, type);

        Directory.CreateDirectory(directoryPath);
        File.WriteAllText(filePath, code);
    }

    async Task<string> FullyQualifyType(TypeDefinition type, List<string> genericArguments, List<GenericParameter> rootGenericParameters, string dependencyType)
    {
        CheckCancellation();

        if(type.IsEnginePrimitive && !type.IsEnum)
        {
            var primitiveType = PrimitiveMapper.MapEnginePrimitive(type);

            if (primitiveType != null)
                return primitiveType.Namespace + "." + primitiveType.Name;
        }

        // Ensure that we have a binding generated for this type
        // We do this even for components, even though they would normally all get generated as part of the enumeration,
        // because generation can be done only for subcategories and the dependencies may lie outside of those.
        // If the type isn't a component, we need to generate a dummy file for it so it can be referenced. It'll contain no actual code.
        if (type.IsComponent)
            await GenerateComponentBinding(type.FullTypeName);
        else if (type.IsEnum)
            await GenerateEnumBinding(type);
        else if (!type.IsComponent)
            await GenerateDummyBinding(type, dependencyType);

        string typeName;

        if(type.IsNested)
        {
            var declaringTypeResult = await link.GetTypeDefinition(type.DeclaringType);

            if (!declaringTypeResult.Success)
                throw new System.Exception($"Failed to fetch declaring type {type.DeclaringType}: {declaringTypeResult.ErrorInfo}");

            typeName = await FullyQualifyType(declaringTypeResult.Definition, genericArguments, rootGenericParameters, type.FullTypeName)
                + "." + type.Name;
        }
        else
            typeName = "global::" + type.Namespace + "." + type.Name;

        if (type.IsGenericType && type.DirectGenericParameterCount > 0)
        {
            // Include all the generic arguments
            var args = new string[type.DirectGenericParameterCount];

            var argsOffset = genericArguments.Count - type.DirectGenericParameterCount;

            for (int i = 0; i < args.Length; i++)
            {
                var arg = genericArguments[argsOffset + i];

                // If it's a generic parameter, just pass it through as is
                if (rootGenericParameters?.Any(p => p.Name == arg) ?? false)
                    args[i] = arg;
                else
                {
                    // Recursively resolve the type definition
                    var argDefinition = await link.GetTypeDefinition(arg);

                    if (!argDefinition.Success)
                        throw new System.Exception($"Failed to fetch arg definition: {argDefinition.ErrorInfo}");

                    args[i] = await FullyQualifyType(argDefinition.Definition, argDefinition.Definition.GenericArguments, rootGenericParameters, dependencyType);
                }
            }

            typeName += $"<{string.Join(",", args)}>";
        }

        return typeName;
    }

    async Task<string> GenerateDummySource(TypeDefinition type, string dependencyType)
    {
        CheckCancellation();

        return await GenerateBindingSource(type, 
            $"// Dummy class, there's no body\n" +
            $"// Generated as dependency for: {dependencyType}", 
            "");
    }

    async Task<string> GenerateDeclaration(TypeDefinition type, string body, string attributes, string overrideBaseDef = null)
    {
        CheckCancellation();

        // Determine the name of the class
        var classDef = type.Name;

        if (type.IsGenericType && type.DirectGenericParameterCount > 0)
        {
            if (type.GenericParameters == null)
                throw new System.Exception($"GenericParameters are missing for type: {type.FullTypeName}");

            // Add the generic parameters
            classDef += $"<{string.Join(",", type.GenericParameters.Select(p => p.Name))}>";
        }

        // Determine the base class name
        string baseDef;

        if (overrideBaseDef != null)
            baseDef = overrideBaseDef;
        else if (type.BaseType == null)
        {
            if (type.Name == "Worker" && type.AssemblyName == "FrooxEngine")
                baseDef = "UnityEngine.MonoBehaviour";
            else if (!type.IsInterface)
                baseDef = "UnityEngine.Object";
            else
                baseDef = null;
        }
        else
        {
            var baseDefinitionResult = await link.GetTypeDefinition(type.BaseType.Type);

            if (!baseDefinitionResult.Success)
                throw new System.Exception($"Exception getting base type for {type.FullTypeName}: {baseDefinitionResult.ErrorInfo}");

            baseDef = await FullyQualifyType(baseDefinitionResult.Definition, type.BaseType.GenericArguments, type.GenericParameters, type.FullTypeName);
        }

        if (!string.IsNullOrEmpty(baseDef))
            baseDef = ": " + baseDef;

        string declarationType;

        if (type.IsInterface)
            declarationType = "interface";
        else if (type.IsEnum)
            declarationType = "enum";
        else if (type.IsAbstract)
            declarationType = "abstract partial class";
        else
            declarationType = "partial class";

            // TODO!!! Generic constraints & Interfaces
            var selfBody = $@"{attributes}
public {declarationType} {classDef} {baseDef}
{{
    {body}
}}";

        return await WrapDeclaration(type, selfBody);
    }

    async Task<string> WrapDeclaration(TypeDefinition type, string declaration)
    {
        if (!type.IsNested)
            return declaration;

        var result = await link.GetTypeDefinition(type.DeclaringType);

        if (!result.Success)
            throw new System.Exception($"Failed to fetch declaring type {type.DeclaringType}: {result.ErrorInfo}");

        var declaringType = result.Definition;

        return await WrapDeclaration(declaringType,
            @$"public partial class {declaringType.Name}
            {{
                {declaration}
            }}");
    }

    async Task<string> GenerateBindingSource(TypeDefinition type, string body, string attributes, string overrideBaseDef = null)
    {
        CheckCancellation();

        var declaration = await GenerateDeclaration(type, body, attributes, overrideBaseDef);

        return $@"
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: {type.FullTypeName}
// Generated on: {System.DateTime.UtcNow.ToString("U")}
// -----------------------------------------------------------------------------

using UnityEngine;

namespace {type.Namespace}
{{
    {declaration}
}}
";
    }
    
    async Task<string> GenerateBindingSource(ComponentDefinition definition)
    {
        CheckCancellation();

        var attributes = new StringBuilder();

        // For non-abstract types & non-generic types we can categorize!
        // Unfortunately Unity doesn't support generic components, so we can't expose those directly
        if(!definition.Type.IsAbstract && !definition.Type.IsGenericType)
        {
            var categoryName = definition.Type.Name;

            var categoryPath = $"FrooxEngine/{definition.CategoryPath ?? "Uncategorized"}/{categoryName}";

            attributes.AppendLine($"[AddComponentMenu(\"{categoryPath}\")]");
        }        

        return await GenerateBindingSource(definition.Type, "", attributes.ToString());
    }

    async ValueTask<ComponentDefinition> GetComponentDefinition(string type)
    {
        CheckCancellation();

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
