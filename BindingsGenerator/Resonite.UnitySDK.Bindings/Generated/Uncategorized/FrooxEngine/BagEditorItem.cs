
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BagEditorItem
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BagEditorItem")]
public partial class BagEditorItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.IWorldElement Item { get => Item_Element.Data; set => Item_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef, global::FrooxEngine.IWorldElement> Item_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Item", Item_Element.Data.ToResoniteReference(context));
}

}
}
