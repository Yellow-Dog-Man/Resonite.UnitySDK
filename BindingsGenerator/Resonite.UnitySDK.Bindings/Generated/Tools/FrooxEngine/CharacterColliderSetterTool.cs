
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterColliderSetterTool
// Generated on: pátek 6. března 2026 14:19:05
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterColliderSetterTool")]
public partial class CharacterColliderSetterTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Boolean MarkGrippable { get => MarkGrippable_Element.Data; set => MarkGrippable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MarkGrippable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MarkGrippable", MarkGrippable_Element.ToLinkField(context));
}

}
}
