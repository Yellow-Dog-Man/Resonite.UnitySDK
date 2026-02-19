
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultFontMaterial", DefaultFontMaterial.ToResoniteReference(context));
members.Add("DisabledOutlineColor", DisabledOutlineColor.ToResoniteLinkField());
members.Add("DisabledFillColor", DisabledFillColor.ToResoniteLinkField());
members.Add("LogoCircle", LogoCircle.ToResoniteLinkField());
members.Add("GenerateColliders", GenerateColliders.ToResoniteLinkField());
members.Add("HighlightRadiusOffset", HighlightRadiusOffset.ToResoniteLinkField());
members.Add("logoMenuMesh", logoMenuMesh.ToResoniteReference(context));
members.Add("circleMenuItems", new ResoniteLink.SyncList()
{
    Elements = circleMenuItems.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("independentMenuItems", new ResoniteLink.SyncList()
{
    Elements = independentMenuItems.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("itemsArcs", new ResoniteLink.SyncList()
{
    Elements = itemsArcs.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_overridesDrive", _overridesDrive.ToResoniteReference(context));
members.Add("_independentDrive", _independentDrive.ToResoniteReference(context));
members.Add("menuItemsSlot", menuItemsSlot.ToResoniteReference(context));
}

}
}
