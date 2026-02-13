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

public partial class ResoniteBindingGenerator
{
    public string BINDINGS_ROOT_PATH => Path.Combine("Assets", "ResoniteSDK", "Bindings", "Generated");

    public int GeneratedComponents { get; private set; }
    public int TotalComponentsToGenerate { get; private set; }
    public float Progress
    {
        get
        {
            if (TotalComponentsToGenerate == 0)
                return 0f;

            return GeneratedComponents / (float)TotalComponentsToGenerate;
        }
    }

    readonly ResoniteLink.LinkInterface link;
    readonly ProgressSynchronizer progress;
    readonly CancellationToken cancellationToken;

    Dictionary<string, ComponentDefinition> _componentDefinitionCache = new Dictionary<string, ComponentDefinition>();
    Dictionary<string, SyncObjectDefinition> _syncObjectDefinitionCache = new Dictionary<string, SyncObjectDefinition>();
    Dictionary<string, TypeDefinition> _typeDefinitionCache = new Dictionary<string, TypeDefinition>();
    HashSet<string> _generatedTypes = new HashSet<string>();

    string _resoniteVersion;
    string _resoniteLinkVersion;

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
            progress?.UpdateProgress("Starting generation", Progress);

            // Delete previous bindings, since we'll regenerate everything
            if (Directory.Exists(BINDINGS_ROOT_PATH))
            {
                progress?.UpdateProgress("Deleting old bindings", Progress);
                Directory.Delete(BINDINGS_ROOT_PATH, true);
            }

            var sessionInfo = await link.GetSessionData();

            _resoniteVersion = sessionInfo.ResoniteVersion;
            _resoniteLinkVersion = sessionInfo.ResoniteLinkVersion;

            // Start generating bindings from the root category. This will work downwards recursively, covering all the component types
            await GenerateComponentBindingsForCategory("");
        }
        catch (System.Exception ex)
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

    bool ShouldGenerateBinding(TypeDefinition type)
    {
        if (type.AssemblyName.StartsWith("System"))
            return false;

        return true;
    }

    public async Task GenerateComponentBindingsForCategory(string categoryPath)
    {
        CheckCancellation();

        var list = await link.GetComponentTypes(categoryPath);

        if (TotalComponentsToGenerate == 0)
            TotalComponentsToGenerate = list.TotalComponentCount;

        // This should never fail unless something went really wrong or we messed up
        if (!list.Success)
            throw new System.Exception($"Failed to fetch component list: {list.ErrorInfo}");

        if (list.ComponentTypes != null)
            foreach (var type in list.ComponentTypes)
                await GenerateComponentBinding(type);

        // If there are subcategories, generate bindings for are those!
        if (list.SubCategories != null)
            foreach (var subCategory in list.SubCategories)
                await GenerateComponentBindingsForCategory(categoryPath + Path.DirectorySeparatorChar + subCategory);
    }

    async Task<string> GenerateFilePath(string directory, TypeDefinition type, string nameSuffix = null)
    {
        var name = await GenerateRawFileName(type) + nameSuffix;

        name += ".cs";

        var path = Path.Combine(directory, name);

        // Make sure we're not overwriting existing files - they should be deleted before hand
        // This makes sure there's no file-name collisions
        if (File.Exists(path))
            throw new System.Exception($"File for {type.FullTypeName} already exists: {path}");

        var directoryPath = Path.GetDirectoryName(path);

        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);

        return path;
    }

    async Task<string> GenerateRawFileName(TypeDefinition type)
    {
        string name;

        if (type.IsNested)
        {
            name = await GenerateRawFileName(await GetTypeDefinition(type.DeclaringType));
            name += "+";
        }
        else if (!string.IsNullOrEmpty(type.Namespace))
            name = type.Namespace + Path.DirectorySeparatorChar;
        else
            name = "";

        name += type.Name;

        if (type.DirectGenericParameterCount > 0)
            name += $"`{type.DirectGenericParameterCount}";

        return name;
    }

    public async Task GenerateSyncObjectBinding(string type)
    {
        CheckCancellation();

        // Only generate bindings once for the same type.
        if (!_generatedTypes.Add(type))
            return;

        var definition = await GetSyncObjectDefinition(type);

        if (definition.Type.IsGenericType && !definition.Type.IsGenericTypeDefinition)
        {
            // This is a generic type instance! We must get the generic type definition in order to be able to generate the binding
            var result = await link.GetGenericTypeDefinition(type);

            if (!result.Success)
                throw new System.Exception($"Failed to get generic type definition for type {type}: {result.ErrorInfo}");

            // Check again - it's possible we generated this component already
            if (!_generatedTypes.Add(result.Definition.FullTypeName))
                return;

            // Get the definition for the generic type definition
            definition = await GetSyncObjectDefinition(result.Definition.FullTypeName);
        }

        var source = await GenerateBindingSource(definition);

        // Figure out the file path for the file
        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, "SyncObjects");
        var filePath = await GenerateFilePath(directoryPath, definition.Type);

        File.WriteAllText(filePath, source);

        // Ensure that all the base types are processed and we have files for those as well
        if (definition.BaseTypeIsSyncObject)
        {
            if (definition.Type.BaseType == null)
                throw new System.Exception($"Base type is missing for sync object {definition.Type.FullTypeName}");

            await GenerateComponentBinding(definition.Type.BaseType.Type);
        }
    }

    public async Task GenerateComponentBinding(string type)
    {
        CheckCancellation();

        // Only generate bindings once for the same type.
        if (!_generatedTypes.Add(type))
            return;

        var definition = await GetComponentDefinition(type);

        progress?.UpdateProgress(definition.Type.FullTypeName, Progress);

        if (definition.Type.IsGenericType && !definition.Type.IsGenericTypeDefinition)
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

        var source = await GenerateBindingSource(definition);

        // Figure out the file path for the file
        var directoryPath = Path.Combine(BINDINGS_ROOT_PATH, definition.CategoryPath ?? "Uncategorized");
        var filePath = await GenerateFilePath(directoryPath, definition.Type);

        File.WriteAllText(filePath, source);

        if (!definition.Type.IsAbstract)
        {
            // Generate wrapper as well
            var wrapperPath = await GenerateFilePath(directoryPath, definition.Type, "Wrapper");
            var wrapperSource = await GenerateWrapperSource(definition);

            File.WriteAllText(wrapperPath, wrapperSource);
        }

        GeneratedComponents++;

        // Ensure that all the base types are processed and we have files for those as well
        if (definition.BaseTypeIsComponent)
        {
            if (definition.Type.BaseType == null)
                throw new System.Exception($"Base type is missing for component {definition.Type.FullTypeName}");

            await GenerateComponentBinding(definition.Type.BaseType.Type);
        }
    }

    public async Task GenerateEnumBinding(TypeDefinition type)
    {
        if (!ShouldGenerateBinding(type))
            return;

        if (!_generatedTypes.Add(type.FullTypeName))
            return;

        var result = await link.GetEnumDefinition(type.FullTypeName);

        if (!result.Success)
            throw new System.Exception($"Failed to fetch enum definition for {type.FullTypeName}: {result.ErrorInfo}");

        var enumDefinition = result.Definition;

        var body = new StringBuilder();

        foreach (var entry in enumDefinition.Values)
            body.AppendLine($"{entry.Key} = {entry.Value},");

        var source = await GenerateBindingSource(type, body.ToString(),
            attributes: enumDefinition.IsFlags ? "[System.Flags]" : "",
            overrideBaseDef: enumDefinition.BackingType);

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
        if (!ShouldGenerateBinding(type))
            return;

        if (!_generatedTypes.Add(type.FullTypeName))
            return;

        progress?.UpdateProgress(type.FullTypeName, Progress);

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

    async Task<string> FullyQualifyType(TypeDefinition type, List<TypeReference> genericArguments, string dependencyType)
    {
        CheckCancellation();

        if (type.IsEnginePrimitive && !type.IsEnum)
        {
            var primitiveType = PrimitiveMapper.MapEnginePrimitive(type);

            if (primitiveType != null)
            {
                if (string.IsNullOrEmpty(primitiveType.Namespace))
                    return primitiveType.Name;
                else
                    return primitiveType.Namespace + "." + primitiveType.Name;
            }
        }

        // Ensure that we have a binding generated for this type
        // We do this even for components, even though they would normally all get generated as part of the enumeration,
        // because generation can be done only for subcategories and the dependencies may lie outside of those.
        // If the type isn't a component, we need to generate a dummy file for it so it can be referenced. It'll contain no actual code.
        if (type.IsComponent)
            await GenerateComponentBinding(type.FullTypeName);
        else if (type.IsSyncObject)
            await GenerateSyncObjectBinding(type.FullTypeName);
        else if (type.IsEnum)
            await GenerateEnumBinding(type);
        else if (!type.IsComponent)
            await GenerateDummyBinding(type, dependencyType);

        string typeName;

        if (type.IsNested)
        {
            var declaringTypeDefinition = await GetTypeDefinition(type.DeclaringType);

            typeName = await FullyQualifyType(declaringTypeDefinition, genericArguments, type.FullTypeName)
                + "." + type.Name;
        }
        else
            typeName = "global::" + type.Namespace + "." + type.Name;

        if (type.IsGenericType && type.DirectGenericParameterCount > 0)
        {
            if (genericArguments == null || genericArguments.Count == 0)
                typeName += $"<{"".PadLeft(type.DirectGenericParameterCount - 1)}>";
            else
            {
                // Include all the generic arguments
                var args = new string[type.DirectGenericParameterCount];

                var argsOffset = genericArguments.Count - type.DirectGenericParameterCount;

                for (int i = 0; i < args.Length; i++)
                {
                    var arg = genericArguments[argsOffset + i];

                    // If it's a generic parameter, just pass it through as is
                    if (arg.IsGenericParameter)
                        args[i] = arg.Type;
                    else
                    {
                        // Recursively resolve the type definition
                        var argDefinition = await GetTypeDefinition(arg.Type);

                        args[i] = await FullyQualifyType(argDefinition, arg.GenericArguments, dependencyType);
                    }
                }

                typeName += $"<{string.Join(",", args)}>";
            }
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

    async Task<string> GenerateDeclaration(TypeDefinition type, string body,
        string attributes = null,
        string overrideBaseDef = null,
        string nameSuffix = null,
        bool includeInterfaces = true)
    {
        CheckCancellation();

        // Determine the name of the class
        var classDef = type.Name + nameSuffix;

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
            if (type.IsValueType)
                baseDef = null;
            else if (type.Name == "Worker" && type.AssemblyName == "FrooxEngine")
                baseDef = "ResoniteObject";
            else if (!type.IsInterface)
                baseDef = "UnityEngine.Object";
            else
                baseDef = null;
        }
        else
        {
            var baseDefinition = await GetTypeDefinition(type.BaseType.Type);

            baseDef = await FullyQualifyType(baseDefinition, type.BaseType.GenericArguments, type.FullTypeName);
        }

        if (!string.IsNullOrEmpty(baseDef))
            baseDef = ": " + baseDef;

        string declarationType;

        if (type.IsInterface)
            declarationType = "interface";
        else if (type.IsEnum)
            declarationType = "enum";
        else if (type.IsValueType)
            declarationType = "struct";
        else if (type.IsAbstract)
            declarationType = "abstract partial class";
        else
            declarationType = "partial class";

        // Collect interface implementations
        if (type.Interfaces != null && includeInterfaces)
            foreach (var @interface in type.Interfaces)
            {
                if (string.IsNullOrEmpty(baseDef))
                    baseDef += ": ";
                else
                    baseDef += ", ";

                var interfaceDefinition = await GetTypeDefinition(@interface.Type);

                baseDef += await FullyQualifyType(interfaceDefinition, @interface.GenericArguments, type.FullTypeName);
            }

        string constraints = "";

        if (type.IsGenericType)
        {
            for (int i = 0; i < type.DirectGenericParameterCount; i++)
            {
                var parameter = type.GenericParameters[type.DirectGenericParameterCount - i - 1];
                constraints += "\t" + await GenerateConstraint(parameter) + "\n";
            }
        }

        // TODO!!! Generic constraints & Interfaces
        var selfBody = $@"{attributes}
[ResoniteTypeName(""{type.FullTypeName}"")]
public {declarationType} {classDef} {baseDef}
{constraints}
{{
    {body}
}}";

        return await WrapDeclaration(type, selfBody);
    }

    async Task<string> GenerateConstraint(GenericParameter parameter)
    {
        var constraints = new List<string>();

        if (parameter.Class)
            constraints.Add("class");

        if (parameter.Struct)
            constraints.Add("struct");

        if (parameter.Unmanaged)
            constraints.Add("unmanaged");

        if (parameter.Enum)
            constraints.Add("System.Enum");

        if (parameter.Types != null)
            foreach (var type in parameter.Types)
            {
                if (type.IsGenericParameter)
                    constraints.Add(type.Type);
                else
                {
                    var typeDefinition = await GetTypeDefinition(type.Type);
                    constraints.Add(await FullyQualifyType(typeDefinition, type.GenericArguments, parameter.Name));
                }
            }

        if (constraints.Count > 0)
            return $"where {parameter.Name} : {string.Join(", ", constraints)}";
        else
            return "";
    }

    async Task<string> WrapDeclaration(TypeDefinition type, string declaration)
    {
        if (!type.IsNested)
            return declaration;

        var declaringType = await GetTypeDefinition(type.DeclaringType);

        var declaringTypeName = declaringType.Name;

        if (declaringType.DirectGenericParameterCount > 0)
            declaringTypeName += $"<{string.Join(",", declaringType.GenericParameters.Select(p => p.Name))}>";

        return await WrapDeclaration(declaringType,
            @$"public partial class {declaringTypeName}
            {{
                {declaration}
            }}");
    }

    async Task<string> GenerateBindingSource(TypeDefinition type, string body, string attributes = null,
        string overrideBaseDef = null, string nameSuffix = null, bool includeInterfaces = true)
    {
        CheckCancellation();

        var declaration = await GenerateDeclaration(type, body, attributes, overrideBaseDef, nameSuffix, includeInterfaces);

        return $@"
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: {type.FullTypeName}
// Generated on: {System.DateTime.UtcNow.ToString("U")}
// Resonite version: {_resoniteVersion}
// Resonite Link Version: {_resoniteLinkVersion}
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace {type.Namespace}
{{
    {declaration}
}}
";
    }

    async Task<string> GenerateWrapperSource(ComponentDefinition definition)
    {
        CheckCancellation();

        if (definition.Type.IsAbstract)
            throw new System.ArgumentException("Wrappers can only be generated for non abstract types");

        // For non-abstract types & non-generic types we can categorize!
        // Unfortunately Unity doesn't support generic components, so we can't expose those directly
        var attributes = new StringBuilder();

        var categoryName = definition.Type.Name;

        var categoryPath = $"FrooxEngine/{definition.CategoryPath ?? "Uncategorized"}/{categoryName}";

        attributes.AppendLine($"[AddComponentMenu(\"{categoryPath}\")]");

        var reference = await FullyQualifyType(definition.Type,
            definition.Type.GenericParameters?.Select(p => new TypeReference()
            {
                IsGenericParameter = true,
                Type = p.Name,
            }).ToList(),
            definition.Type.FullTypeName);

        return await GenerateBindingSource(definition.Type, "",
            attributes: attributes.ToString(),
            overrideBaseDef: $"ResoniteComponent<{reference}>",
            nameSuffix: "Wrapper",
            includeInterfaces: false);
    }

    async Task<string> GenerateBindingSource(ComponentDefinition definition)
    {
        CheckCancellation();

        var body = await GenerateBody(definition.Members, definition.Type);

        return await GenerateBindingSource(definition.Type, body, attributes: "[Serializable]");
    }

    async Task<string> GenerateBindingSource(SyncObjectDefinition definition)
    {
        CheckCancellation();

        var body = await GenerateBody(definition.Members, definition.Type);

        return await GenerateBindingSource(definition.Type, body,
            attributes: "[Serializable]");
    }

    async ValueTask<SyncObjectDefinition> GetSyncObjectDefinition(string type)
    {
        CheckCancellation();

        if (_syncObjectDefinitionCache.TryGetValue(type, out var definition))
            return definition;

        // We specifically fetch un-flattened definitions.
        // We will work our way upwards the types to mimic the inheritance hierarchy.
        var definitionResult = await link.GetSyncObjectDefinition(type, false);

        if (!definitionResult.Success)
            throw new System.Exception($"Failed to fetch sync object definition for type {type}:\n{definitionResult.ErrorInfo}");

        definition = definitionResult.Definition;

        // Store it in the cache before returning it
        _syncObjectDefinitionCache.Add(type, definition);

        // We can also store the type definition in case we don't have it!
        _typeDefinitionCache.TryAdd(definition.Type.FullTypeName, definition.Type);

        return definition;
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

        // We can also store the type definition in case we don't have it!
        _typeDefinitionCache.TryAdd(definition.Type.FullTypeName, definition.Type);

        return definition;
    }

    async ValueTask<TypeDefinition> GetTypeDefinition(string type)
    {
        CheckCancellation();

        if (_typeDefinitionCache.TryGetValue(type, out var definition))
            return definition;

        // We specifically fetch un-flattened component definitions.
        // We will work our way upwards the types to mimic the inheritance hierarchy.
        var definitionResult = await link.GetTypeDefinition(type);

        if (!definitionResult.Success)
            throw new System.Exception($"Failed to fetch type definition for type {type}:\n{definitionResult.ErrorInfo}");

        definition = definitionResult.Definition;

        // Store it in the cache before returning it
        _typeDefinitionCache.Add(type, definition);

        return definition;
    }
}
