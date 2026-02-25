
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiLineMesh+Line
// Generated on: středa 25. února 2026 16:13:04
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
    public partial class MultiLineMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiLineMesh+Line")]
public partial class Line : global::FrooxEngine.SyncObject

{
    public global::System.Single Scale;
public UnityEngine.Color Color;
public global::System.Int32 Points;
public global::Elements.Assets.SegmentedBuilder.Topology Topology;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::System.Boolean DualSided;
public global::System.Boolean AbsolutePointOffets;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean ScaleUVByCircumference;
public global::System.Boolean PreciseUV;
public UnityEngine.Vector3[] Positions;
public global::System.Single[] Scales;
public UnityEngine.Quaternion[] Orientations;
public UnityEngine.Color[] Colors;
public global::Renderite.Shared.ColorProfile Profile;
public UnityEngine.Vector3[] PointOffsets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("Topology", Topology.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("AbsolutePointOffets", AbsolutePointOffets.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVByCircumference", ScaleUVByCircumference.ToResoniteLinkField());
members.Add("PreciseUV", PreciseUV.ToResoniteLinkField());
members.Add("Positions", Positions.ToResoniteLinkArray());
members.Add("Scales", Scales.ToResoniteLinkArray());
members.Add("Orientations", Orientations.ToResoniteLinkArray());
members.Add("Colors", Colors.ToResoniteLinkArray());
members.Add("Profile", Profile.ToResoniteLinkField());
members.Add("PointOffsets", PointOffsets.ToResoniteLinkArray());
}

}
            }
}
