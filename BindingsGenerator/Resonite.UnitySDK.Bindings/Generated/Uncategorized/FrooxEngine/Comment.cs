
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Comment
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Comment")]
public partial class Comment : global::FrooxEngine.Component

{
    public global::System.String Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text_Element.ToLinkField(context));
}

}
}
