
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh
// Generated on: pátek 13. února 2026 23:23:07
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh")]
public partial class LegacyCircleSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single ExpandLerp;
public global::System.Boolean InnerCircle;
public global::System.Single RadiusStart;
public global::System.Single Thickness;
public global::System.Single MainSegmentArc;
public global::System.Single SeparationAngle;
public global::System.Single MenuMainSegmentArc;
public global::System.Int32 CircleItemCount;
public global::System.Single MenuRadiusStart;
public global::System.Single MenuThickness;
public UnityEngine.ColorX FillColor;
public UnityEngine.ColorX OutlineColor;
public System.Collections.Generic.List<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> CircleItemOverrides;
public System.Collections.Generic.List<global::FrooxEngine.LegacyCircleSegmentMesh.MenuSegment> IndependentSegments;
public global::System.Single OutlineWidth;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ExpandLerp", ExpandLerp.ToResoniteLinkField());
members.Add("InnerCircle", InnerCircle.ToResoniteLinkField());
members.Add("RadiusStart", RadiusStart.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("MainSegmentArc", MainSegmentArc.ToResoniteLinkField());
members.Add("SeparationAngle", SeparationAngle.ToResoniteLinkField());
members.Add("MenuMainSegmentArc", MenuMainSegmentArc.ToResoniteLinkField());
members.Add("CircleItemCount", CircleItemCount.ToResoniteLinkField());
members.Add("MenuRadiusStart", MenuRadiusStart.ToResoniteLinkField());
members.Add("MenuThickness", MenuThickness.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("CircleItemOverrides", new ResoniteLink.SyncList()
{
    Elements = CircleItemOverrides.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("IndependentSegments", new ResoniteLink.SyncList()
{
    Elements = IndependentSegments.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("OutlineWidth", OutlineWidth.ToResoniteLinkField());
}

}
}
