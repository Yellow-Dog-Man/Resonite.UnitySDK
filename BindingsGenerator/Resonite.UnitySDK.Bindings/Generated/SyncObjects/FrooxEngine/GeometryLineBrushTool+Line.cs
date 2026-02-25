
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool+Line
// Generated on: středa 25. února 2026 16:14:28
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
    public partial class GeometryLineBrushTool
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeometryLineBrushTool+Line")]
public partial class Line : global::FrooxEngine.SyncObject

{
    public global::Elements.Assets.SegmentedBuilder.Topology Topology;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;
public global::System.Int32 Points;
public global::System.Boolean DualSided;
public global::System.Boolean AbsolutePointOffsets;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean ScaleUVByCircumference;
public global::System.Boolean PreciseUV;
public UnityEngine.Vector3[] PointOffsets;
public global::FrooxEngine.LineColorMode ColorMode;
public UnityEngine.Color Color;
public global::System.Boolean UseTipRotation;
public global::System.Single MaxSize;
public global::FrooxEngine.Slot OverrideTip;
public global::FrooxEngine.Slot OverrideTipRotation;
public global::FrooxEngine.RootSpace OffsetSpace;
public global::FrooxEngine.RootSpace RotationSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Topology", Topology.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("AbsolutePointOffsets", AbsolutePointOffsets.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVByCircumference", ScaleUVByCircumference.ToResoniteLinkField());
members.Add("PreciseUV", PreciseUV.ToResoniteLinkField());
members.Add("PointOffsets", PointOffsets.ToResoniteLinkArray());
members.Add("ColorMode", ColorMode.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("UseTipRotation", UseTipRotation.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("OverrideTip", OverrideTip.ToResoniteReference(context));
members.Add("OverrideTipRotation", OverrideTipRotation.ToResoniteReference(context));
members.Add("OffsetSpace", new ResoniteLink.SyncObject() { Members = OffsetSpace.CollectMembers(context) });
members.Add("RotationSpace", new ResoniteLink.SyncObject() { Members = RotationSpace.CollectMembers(context) });
}

}
            }
}
