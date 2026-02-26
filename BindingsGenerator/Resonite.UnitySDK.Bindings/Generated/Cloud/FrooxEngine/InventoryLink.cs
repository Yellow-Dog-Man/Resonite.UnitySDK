
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryLink
// Generated on: čtvrtek 26. února 2026 10:03:37
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InventoryLink")]
public partial class InventoryLink : global::FrooxEngine.Component

{
    public global::System.String TargetName { get => TargetName_Element.Data; set => TargetName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> TargetName_Element = new();
public System.Uri Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetName", TargetName_Element.Data.ToResoniteLinkField());
members.Add("Target", Target_Element.Data.ToResoniteLinkField());
}

}
}
