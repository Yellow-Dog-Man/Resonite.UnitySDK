
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController
// Generated on: čtvrtek 26. února 2026 15:09:06
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.TextUnlitMaterial DefaultFontMaterial { get => DefaultFontMaterial_Element.Data; set => DefaultFontMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextUnlitMaterial>, global::FrooxEngine.TextUnlitMaterial> DefaultFontMaterial_Element = new();
public UnityEngine.ColorX DisabledOutlineColor { get => DisabledOutlineColor_Element.Data; set => DisabledOutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> DisabledOutlineColor_Element = new();
public UnityEngine.ColorX DisabledFillColor { get => DisabledFillColor_Element.Data; set => DisabledFillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> DisabledFillColor_Element = new();
public global::System.Boolean LogoCircle { get => LogoCircle_Element.Data; set => LogoCircle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LogoCircle_Element = new();
public global::System.Boolean GenerateColliders { get => GenerateColliders_Element.Data; set => GenerateColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GenerateColliders_Element = new();
public global::System.Single HighlightRadiusOffset { get => HighlightRadiusOffset_Element.Data; set => HighlightRadiusOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HighlightRadiusOffset_Element = new();
public global::FrooxEngine.LegacyCircleSegmentMesh logoMenuMesh { get => logoMenuMesh_Element.Data; set => logoMenuMesh_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyCircleSegmentMesh>, global::FrooxEngine.LegacyCircleSegmentMesh> logoMenuMesh_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> circleMenuItems = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> independentMenuItems = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc>, global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc> itemsArcs = new();
public global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> _overridesDrive { get => _overridesDrive_Element.Data; set => _overridesDrive_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>>, global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>> _overridesDrive_Element = new();
public global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> _independentDrive { get => _independentDrive_Element.Data; set => _independentDrive_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>>, global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>> _independentDrive_Element = new();
public global::FrooxEngine.Slot menuItemsSlot { get => menuItemsSlot_Element.Data; set => menuItemsSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> menuItemsSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultFontMaterial", DefaultFontMaterial_Element.ToLinkReference(context));
members.Add("DisabledOutlineColor", DisabledOutlineColor_Element.ToLinkField(context));
members.Add("DisabledFillColor", DisabledFillColor_Element.ToLinkField(context));
members.Add("LogoCircle", LogoCircle_Element.ToLinkField(context));
members.Add("GenerateColliders", GenerateColliders_Element.ToLinkField(context));
members.Add("HighlightRadiusOffset", HighlightRadiusOffset_Element.ToLinkField(context));
members.Add("logoMenuMesh", logoMenuMesh_Element.ToLinkReference(context));
members.Add("circleMenuItems", circleMenuItems.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("independentMenuItems", independentMenuItems.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("itemsArcs", itemsArcs.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_overridesDrive", _overridesDrive_Element.ToLinkReference(context));
members.Add("_independentDrive", _independentDrive_Element.ToLinkReference(context));
members.Add("menuItemsSlot", menuItemsSlot_Element.ToLinkReference(context));
}

}
}
