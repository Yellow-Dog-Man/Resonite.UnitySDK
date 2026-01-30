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

                default:
                    str.AppendLine($"// {member.Key} - Unsupported member type: {member.Value.GetType().Name}");
                    break;
            }
        }

        return str.ToString();
    }

    async Task GenerateField(StringBuilder str, string name, FieldDefinition field, TypeDefinition containerType)
    {
        var typeDec = await GenerateValueTypeDeclaration(field.ValueType, containerType);

        if(typeDec == null)
            str.AppendLine($"// {name} - Unsupported field value type: {field.ValueType}");
        else
            str.AppendLine($"public {typeDec} {name};");
    }

    async ValueTask<string> GenerateValueTypeDeclaration(string valueType, TypeDefinition containerType)
    {
        // If it's a generic type, just reference it directly
        if (containerType.IsGenericType && containerType.GenericParameters.Any(p => p.Name == valueType))
            return valueType;

        var typeDefinition = await GetTypeDefinition(valueType);

        // Special case, when the type is contained within the container type (typically enum declared within a component)
        // We can refer to it by the typename directly
        if (typeDefinition.IsNested && typeDefinition.DeclaringType == containerType.FullTypeName)
        {
            // Make sure bindings are generated
            if (typeDefinition.IsEnum)
                await GenerateEnumBinding(typeDefinition);

            return typeDefinition.Name;
        }

        return await FullyQualifyType(typeDefinition, typeDefinition.GenericArguments, typeDefinition.GenericParameters, valueType);
    }
}
