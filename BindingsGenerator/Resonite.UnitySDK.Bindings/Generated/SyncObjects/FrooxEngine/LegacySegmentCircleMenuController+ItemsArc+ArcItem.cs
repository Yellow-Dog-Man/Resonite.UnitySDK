
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc+ArcItem
// Generated on: čtvrtek 26. února 2026 10:04:39
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
    public partial class LegacySegmentCircleMenuController
            {
                public partial class ItemsArc
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc+ArcItem")]
public partial class ArcItem : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacySegmentCircleMenuController.Item Item { get => Item_Element.Data; set => Item_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> Item_Element = new();
public global::FrooxEngine.IField<global::System.Single> AngleStartDrive { get => AngleStartDrive_Element.Data; set => AngleStartDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> AngleStartDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Item", Item_Element.Data.ToResoniteReference(context));
members.Add("AngleStartDrive", AngleStartDrive_Element.Data.ToResoniteReference(context));
}

}
            }
            }
}
