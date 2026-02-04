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
            str.Append("public ");
            await GenerateMemberDeclaration(str, member.Value, containerType);
            str.AppendLine($" {member.Key};");
        }

        return str.ToString();
    }

    async Task GenerateMemberDeclaration(StringBuilder str, MemberDefinition member, TypeDefinition containerType)
    {
        switch (member)
        {
            case FieldDefinition field:
                await GenerateFieldDeclaration(str, field, containerType);
                break;

            case ReferenceDefinition reference:
                await GenerateReferenceDeclaration(str, reference, containerType);
                break;

            case ListDefinition list:
                await GenerateListDeclaration(str, list, containerType);
                break;

            case ArrayDefinition array:
                await GenerateArrayDeclaration(str, array, containerType);
                break;

            case SyncObjectMemberDefinition syncObject:
                await GenerateSyncObjectDeclaration(str, syncObject, containerType);
                break;

            case EmptyMemberDefinition emptyMember:
                await GenerateEmptyMemberDeclaration(str, emptyMember, containerType);
                break;

            default:
                throw new System.NotImplementedException($"Member type not implemented: {member.GetType().FullName}");
        }
    }

    async Task GenerateFieldDeclaration(StringBuilder str, FieldDefinition field, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(field.ValueType, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate field declaration for type: {field.ValueType}");

        str.Append(typeDec);
    }

    async Task GenerateReferenceDeclaration(StringBuilder str, ReferenceDefinition reference, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(reference.TargetType, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate reference declaration for type: {reference.TargetType}");

        str.Append(typeDec);
    }

    async Task GenerateSyncObjectDeclaration(StringBuilder str, SyncObjectMemberDefinition syncObject, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(syncObject.Type, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate type declaration for sync object: {syncObject.Type.Type}");

        str.Append(typeDec);
    }

    async Task GenerateListDeclaration(StringBuilder str, ListDefinition list, TypeDefinition containerType)
    {
        str.Append("System.Collections.Generic.List<");
        await GenerateMemberDeclaration(str, list.ElementDefinition, containerType);
        str.Append(">");
    }

    async Task GenerateArrayDeclaration(StringBuilder str, ArrayDefinition array, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(array.ValueType, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate array declaration for type: {array.ValueType}");

        str.Append(typeDec);
        str.Append("[]");
    }

    async Task GenerateEmptyMemberDeclaration(StringBuilder str, EmptyMemberDefinition empty, TypeDefinition containerType)
    {
        var typeDec = await GenerateTypeDeclaration(empty.MemberType, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate empty member declaration for type: {empty.MemberType}");

        str.Append(typeDec);
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
