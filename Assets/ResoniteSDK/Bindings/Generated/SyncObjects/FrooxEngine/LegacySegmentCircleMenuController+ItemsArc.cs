
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc
// Generated on: čtvrtek 19. února 2026 8:00:22
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc")]
public partial class ItemsArc : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacySegmentCircleMenuController.Item CenterItem;
public global::System.Single SeparationAngle;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _left;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _right;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CenterItem", CenterItem.ToResoniteReference(context));
members.Add("SeparationAngle", SeparationAngle.ToResoniteLinkField());
members.Add("_left", new ResoniteLink.SyncList()
{
    Elements = _left.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_right", new ResoniteLink.SyncList()
{
    Elements = _right.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
            }
}
