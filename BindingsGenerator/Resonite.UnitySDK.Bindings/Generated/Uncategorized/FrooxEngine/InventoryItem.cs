
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryItem
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InventoryItem")]
public partial class InventoryItem : global::FrooxEngine.Component

{
    public global::System.Boolean RelativeToUserRoot { get => RelativeToUserRoot_Element.Data; set => RelativeToUserRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RelativeToUserRoot_Element = new();
public UnityEngine.Quaternion SavedRotation { get => SavedRotation_Element.Data; set => SavedRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> SavedRotation_Element = new();
public UnityEngine.Vector3 SavedScale { get => SavedScale_Element.Data; set => SavedScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SavedScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeToUserRoot", RelativeToUserRoot_Element.ToLinkField(context));
members.Add("SavedRotation", SavedRotation_Element.ToLinkField(context));
members.Add("SavedScale", SavedScale_Element.ToLinkField(context));
}

}
}
