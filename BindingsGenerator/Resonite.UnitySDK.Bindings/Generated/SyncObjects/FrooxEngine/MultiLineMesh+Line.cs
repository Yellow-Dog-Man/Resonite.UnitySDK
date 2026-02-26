
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiLineMesh+Line
// Generated on: čtvrtek 26. února 2026 10:03:36
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
    public global::System.Single Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Scale_Element = new();
public UnityEngine.Color Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> Color_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::Elements.Assets.SegmentedBuilder.Topology Topology { get => Topology_Element.Data; set => Topology_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Topology>, global::Elements.Assets.SegmentedBuilder.Topology> Topology_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public global::System.Boolean AbsolutePointOffets { get => AbsolutePointOffets_Element.Data; set => AbsolutePointOffets_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AbsolutePointOffets_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public global::System.Boolean ScaleUVByCircumference { get => ScaleUVByCircumference_Element.Data; set => ScaleUVByCircumference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUVByCircumference_Element = new();
public global::System.Boolean PreciseUV { get => PreciseUV_Element.Data; set => PreciseUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreciseUV_Element = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> Positions = new();
public global::SyncArray<global::FrooxEngine.SyncArray<global::System.Single>, global::System.Single> Scales = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Quaternion>, UnityEngine.Quaternion> Orientations = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Color>, UnityEngine.Color> Colors = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> PointOffsets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Scale", Scale_Element.Data.ToResoniteLinkField());
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("Points", Points_Element.Data.ToResoniteLinkField());
members.Add("Topology", Topology_Element.Data.ToResoniteLinkField());
members.Add("Shading", Shading_Element.Data.ToResoniteLinkField());
members.Add("Ends", Ends_Element.Data.ToResoniteLinkField());
members.Add("DualSided", DualSided_Element.Data.ToResoniteLinkField());
members.Add("AbsolutePointOffets", AbsolutePointOffets_Element.Data.ToResoniteLinkField());
members.Add("UVScale", UVScale_Element.Data.ToResoniteLinkField());
members.Add("ScaleUVByCircumference", ScaleUVByCircumference_Element.Data.ToResoniteLinkField());
members.Add("PreciseUV", PreciseUV_Element.Data.ToResoniteLinkField());
members.Add("Positions", Positions.Data.ToResoniteLinkArray());
members.Add("Scales", Scales.Data.ToResoniteLinkArray());
members.Add("Orientations", Orientations.Data.ToResoniteLinkArray());
members.Add("Colors", Colors.Data.ToResoniteLinkArray());
members.Add("Profile", Profile_Element.Data.ToResoniteLinkField());
members.Add("PointOffsets", PointOffsets.Data.ToResoniteLinkArray());
}

}
            }
}
