
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController")]
public partial class LegacySegmentCircleMenuController : global::FrooxEngine.Component

{
    public global::FrooxEngine.TextUnlitMaterial DefaultFontMaterial;
public UnityEngine.ColorX DisabledOutlineColor;
public UnityEngine.ColorX DisabledFillColor;
public global::System.Boolean LogoCircle;
public global::System.Boolean GenerateColliders;
public global::System.Single HighlightRadiusOffset;
public global::FrooxEngine.LegacyCircleSegmentMesh logoMenuMesh;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.Item> circleMenuItems;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.Item> independentMenuItems;
public System.Collections.Generic.List<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc> itemsArcs;
public global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> _overridesDrive;
public global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> _independentDrive;
public global::FrooxEngine.Slot menuItemsSlot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DefaultFontMaterial", new ResoniteLink.Reference() { });
members.Add("DisabledOutlineColor", DisabledOutlineColor.ToResoniteLinkField());
members.Add("DisabledFillColor", DisabledFillColor.ToResoniteLinkField());
members.Add("LogoCircle", LogoCircle.ToResoniteLinkField());
members.Add("GenerateColliders", GenerateColliders.ToResoniteLinkField());
members.Add("HighlightRadiusOffset", HighlightRadiusOffset.ToResoniteLinkField());
members.Add("logoMenuMesh", new ResoniteLink.Reference() { });
members.Add("circleMenuItems", new ResoniteLink.SyncList()
{
    Elements = circleMenuItems.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("independentMenuItems", new ResoniteLink.SyncList()
{
    Elements = independentMenuItems.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("itemsArcs", new ResoniteLink.SyncList()
{
    Elements = itemsArcs.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_overridesDrive", new ResoniteLink.Reference() { });
members.Add("_independentDrive", new ResoniteLink.Reference() { });
members.Add("menuItemsSlot", new ResoniteLink.Reference() { });
}

}
}
