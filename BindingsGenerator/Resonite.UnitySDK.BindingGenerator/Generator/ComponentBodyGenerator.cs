using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        str.AppendLine();

        str.AppendLine(@$"public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{{
    base.CollectMembers(members, context);");

        // Generate the data conversion for the members
        foreach (var member in members)
        {
            str.Append($"members.Add(\"{member.Key}\", ");
            await GenerateMemberCollection(str, member.Key, member.Value, containerType);
            str.AppendLine(");");
        }

        str.AppendLine("}");

        return str.ToString();
    }

    async Task GenerateMemberDeclaration(StringBuilder str, MemberDefinition member, TypeDefinition containerType)
    {
        /*if (member.Type == null)
            throw new System.Exception($"Type is null for member {member} on container: {containerType.FullTypeName}");

        var memberTypeDec = await GenerateTypeDeclaration(member.Type, containerType);

        str.Append("Element<");
        str.Append(memberTypeDec);
        str.AppendLine(",");*/

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

            case SyncPlaybackDefinition playback:
                str.Append("PlaybackState");
                break;

            default:
                throw new System.NotImplementedException($"Member type not implemented: {member.GetType().FullName}");
        }

        //str.Append(">");
    }

    async Task GenerateMemberCollection(StringBuilder str, string name, MemberDefinition member, TypeDefinition containerType)
    {
        switch(member)
        {
            case FieldDefinition field:
                await GenerateFieldCollection(str, name, field, containerType);
                break;

            case ReferenceDefinition reference:
                await GenerateReferenceCollection(str, name, reference, containerType);
                break;

            case ListDefinition list:
                await GenerateListCollection(str, name, list, containerType);
                break;

            case ArrayDefinition array:
                await GenerateArrayCollection(str, name, array, containerType);
                break;

            case SyncObjectMemberDefinition syncObject:
                await GenerateSyncObjectCollection(str, name, syncObject, containerType);
                break;

            case EmptyMemberDefinition emptyMember:
                str.Append("new ResoniteLink.EmptyElement()");
                break;

            case SyncPlaybackDefinition playback:
                str.Append($"{name}.ToResoniteLink()");
                break;

            default:
                throw new System.NotImplementedException($"Member type not implemented: {member.GetType().FullName}");
        }
    }

    #region DECLARATIONS

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
        var typeDec = await GenerateTypeDeclaration(empty.Type, containerType);

        if (typeDec == null)
            throw new System.Exception($"Failed to generate empty member declaration for type: {empty.Type}");

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
            throw new System.Exception($"Failed to qualify type declaration: {type.Type}\nOn container: {containerType.FullTypeName}\n" +
                $"Error: {ex}");
        }
    }

    #endregion

    #region COLLECTIONS

    async Task GenerateFieldCollection(StringBuilder str, string name, FieldDefinition field, TypeDefinition containerType)
    {
        str.Append($"{name}.ToResoniteLinkField()");
    }

    async Task GenerateReferenceCollection(StringBuilder str, string name, ReferenceDefinition reference, TypeDefinition containerType)
    {
        str.Append($"{name}.ToResoniteReference(context)");
    }

    async Task GenerateListCollection(StringBuilder str, string name, ListDefinition list, TypeDefinition containerType)
    {
        str.Append($@"new ResoniteLink.SyncList()
{{
    Elements = {name}.ConvertList(m => ");

        // Generate collection for the nested member 
        await GenerateMemberCollection(str, "m", list.ElementDefinition, containerType);

        str.Append(@")
}");
    }

    async Task GenerateArrayCollection(StringBuilder str, string name, ArrayDefinition array, TypeDefinition containerType)
    {
        str.Append($"{name}.ToResoniteLinkArray()");
    }

    async Task GenerateSyncObjectCollection(StringBuilder str, string name, SyncObjectMemberDefinition syncObject, TypeDefinition containerType)
    {
        str.Append(@$"new ResoniteLink.SyncObject() {{ Members = {name}.CollectMembers(context) }}");
    }

    #endregion
}
