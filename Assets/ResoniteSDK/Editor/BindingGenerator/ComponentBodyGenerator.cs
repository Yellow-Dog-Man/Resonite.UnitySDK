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
    public async Task<string> GenerateBody(Dictionary<string, MemberDefinition> members, TypeDefinition containerType)
    {
        var str = new StringBuilder();

        foreach(var member in members)
        {
            switch(member.Value)
            {
                case FieldDefinition field:
                    await GenerateField(str, member.Key, field, containerType);
                    break;

                case ReferenceDefinition reference:
                    await GenerateReference(str, member.Key, reference, containerType);
                    break;

                case SyncObjectMemberDefinition syncObject:
                    await GenerateSyncObject(str, member.Key, syncObject, containerType);
                    break;

                default:
                    str.AppendLine($"// {member.Key} - Unsupported member type: {member.Value.GetType().Name}");
                    break;
            }
        }

        return str.ToString();
    }

    async Task GenerateField(StringBuilder str, string name, FieldDefinition field, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(field.ValueType, containerType);

        if(typeDec == null)
            str.AppendLine($"// {name} - Unsupported field value type: {field.ValueType}");
        else
            str.AppendLine($"public {typeDec} {name};");
    }

    async Task GenerateReference(StringBuilder str, string name, ReferenceDefinition reference, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(reference.TargetType, containerType);

        if (typeDec == null)
            str.AppendLine($"// {name} - Unsupported reference value type: {reference.TargetType}");
        else
            str.AppendLine($"public {typeDec} {name};");
    }

    async Task GenerateSyncObject(StringBuilder str, string name, SyncObjectMemberDefinition syncObject, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(syncObject.Type, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate type declaration for sync object: {syncObject.Type.Type}");

        str.AppendLine($"public {typeDec} {name};");
    }

    async ValueTask<string> GenerateTypeDeclaration(TypeReference type, TypeDefinition containerType)
    {
        if (type.IsGenericParameter)
            return type.Type;

        try
        {
            var typeDefinition = await GetTypeDefinition(type.Type);

            return await FullyQualifyType(typeDefinition, type.GenericArguments, containerType.FullTypeName);
        }
        catch(System.Exception ex)
        {
            throw new System.Exception($"Failed to qualify type declaration: {type}\nOn container: {containerType.FullTypeName}\n" +
                $"Error: {ex}");
        }
    }
}
