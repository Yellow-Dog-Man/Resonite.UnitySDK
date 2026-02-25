
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InventoryItem
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InventoryItem")]
public partial class InventoryItem : global::FrooxEngine.Component

{
    public global::System.Boolean RelativeToUserRoot;
public UnityEngine.Quaternion SavedRotation;
public UnityEngine.Vector3 SavedScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeToUserRoot", RelativeToUserRoot.ToResoniteLinkField());
members.Add("SavedRotation", SavedRotation.ToResoniteLinkField());
members.Add("SavedScale", SavedScale.ToResoniteLinkField());
}

}
}
