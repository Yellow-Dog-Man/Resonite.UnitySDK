
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc
// Generated on: pátek 13. února 2026 5:52:24
// Resonite version: 2026.2.13.254
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
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc")]
public partial class ItemsArc : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacySegmentCircleMenuController.Item CenterItem;
public global::System.Single SeparationAngle;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _left;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _right;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CenterItem", new ResoniteLink.Reference() { });
members.Add("SeparationAngle", SeparationAngle.ToResoniteLinkField());
members.Add("_left", new ResoniteLink.SyncList()
{
    Elements = _left.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_right", new ResoniteLink.SyncList()
{
    Elements = _right.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
            }
}
