
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicTypeVariable
// Generated on: čtvrtek 26. února 2026 12:26:54
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicTypeVariable")]
public partial class DynamicTypeVariable : global::FrooxEngine.DynamicVariableBase<System.String>

{
    public System.String Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> Value_Element = new();
public global::System.Boolean OverrideOnLink { get => OverrideOnLink_Element.Data; set => OverrideOnLink_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OverrideOnLink_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkField(context));
members.Add("OverrideOnLink", OverrideOnLink_Element.ToLinkField(context));
}

}
}
