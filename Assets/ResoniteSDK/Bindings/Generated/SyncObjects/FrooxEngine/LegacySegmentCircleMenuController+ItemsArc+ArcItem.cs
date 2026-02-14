
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc+ArcItem
// Generated on: sobota 14. února 2026 8:58:37
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.LegacySegmentCircleMenuController.Item Item;
public global::FrooxEngine.IField<global::System.Single> AngleStartDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Item", Item.ToResoniteReference(context));
members.Add("AngleStartDrive", AngleStartDrive.ToResoniteReference(context));
}

}
            }
            }
}
