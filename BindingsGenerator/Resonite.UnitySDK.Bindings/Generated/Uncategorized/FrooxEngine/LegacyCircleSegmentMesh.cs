
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh")]
public partial class LegacyCircleSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single ExpandLerp { get => ExpandLerp_Element.Data; set => ExpandLerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ExpandLerp_Element = new();
public global::System.Boolean InnerCircle { get => InnerCircle_Element.Data; set => InnerCircle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InnerCircle_Element = new();
public global::System.Single RadiusStart { get => RadiusStart_Element.Data; set => RadiusStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusStart_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single MainSegmentArc { get => MainSegmentArc_Element.Data; set => MainSegmentArc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MainSegmentArc_Element = new();
public global::System.Single SeparationAngle { get => SeparationAngle_Element.Data; set => SeparationAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SeparationAngle_Element = new();
public global::System.Single MenuMainSegmentArc { get => MenuMainSegmentArc_Element.Data; set => MenuMainSegmentArc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MenuMainSegmentArc_Element = new();
public global::System.Int32 CircleItemCount { get => CircleItemCount_Element.Data; set => CircleItemCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CircleItemCount_Element = new();
public global::System.Single MenuRadiusStart { get => MenuRadiusStart_Element.Data; set => MenuRadiusStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MenuRadiusStart_Element = new();
public global::System.Single MenuThickness { get => MenuThickness_Element.Data; set => MenuThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MenuThickness_Element = new();
public UnityEngine.ColorX FillColor { get => FillColor_Element.Data; set => FillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillColor_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>, global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> CircleItemOverrides = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment>, global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> IndependentSegments = new();
public global::System.Single OutlineWidth { get => OutlineWidth_Element.Data; set => OutlineWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineWidth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ExpandLerp", ExpandLerp_Element.ToLinkField(context));
members.Add("InnerCircle", InnerCircle_Element.ToLinkField(context));
members.Add("RadiusStart", RadiusStart_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("MainSegmentArc", MainSegmentArc_Element.ToLinkField(context));
members.Add("SeparationAngle", SeparationAngle_Element.ToLinkField(context));
members.Add("MenuMainSegmentArc", MenuMainSegmentArc_Element.ToLinkField(context));
members.Add("CircleItemCount", CircleItemCount_Element.ToLinkField(context));
members.Add("MenuRadiusStart", MenuRadiusStart_Element.ToLinkField(context));
members.Add("MenuThickness", MenuThickness_Element.ToLinkField(context));
members.Add("FillColor", FillColor_Element.ToLinkField(context));
members.Add("OutlineColor", OutlineColor_Element.ToLinkField(context));
members.Add("CircleItemOverrides", CircleItemOverrides.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("IndependentSegments", IndependentSegments.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("OutlineWidth", OutlineWidth_Element.ToLinkField(context));
}

}
}
