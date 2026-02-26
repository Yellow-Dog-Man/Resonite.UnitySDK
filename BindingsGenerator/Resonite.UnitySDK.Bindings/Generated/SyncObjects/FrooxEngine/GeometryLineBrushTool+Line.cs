
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool+Line
// Generated on: čtvrtek 26. února 2026 15:09:07
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
    public partial class GeometryLineBrushTool
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeometryLineBrushTool+Line")]
public partial class Line : global::FrooxEngine.SyncObject

{
    public global::Elements.Assets.SegmentedBuilder.Topology Topology { get => Topology_Element.Data; set => Topology_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Topology>, global::Elements.Assets.SegmentedBuilder.Topology> Topology_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public global::System.Boolean AbsolutePointOffsets { get => AbsolutePointOffsets_Element.Data; set => AbsolutePointOffsets_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AbsolutePointOffsets_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public global::System.Boolean ScaleUVByCircumference { get => ScaleUVByCircumference_Element.Data; set => ScaleUVByCircumference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUVByCircumference_Element = new();
public global::System.Boolean PreciseUV { get => PreciseUV_Element.Data; set => PreciseUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreciseUV_Element = new();
public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> PointOffsets = new();
public global::FrooxEngine.LineColorMode ColorMode { get => ColorMode_Element.Data; set => ColorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LineColorMode>, global::FrooxEngine.LineColorMode> ColorMode_Element = new();
public UnityEngine.Color Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> Color_Element = new();
public global::System.Boolean UseTipRotation { get => UseTipRotation_Element.Data; set => UseTipRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseTipRotation_Element = new();
public global::System.Single MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSize_Element = new();
public global::FrooxEngine.Slot OverrideTip { get => OverrideTip_Element.Data; set => OverrideTip_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideTip_Element = new();
public global::FrooxEngine.Slot OverrideTipRotation { get => OverrideTipRotation_Element.Data; set => OverrideTipRotation_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideTipRotation_Element = new();
public global::FrooxEngine.RootSpace OffsetSpace = new();
public global::FrooxEngine.RootSpace RotationSpace = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Topology", Topology_Element.ToLinkField(context));
members.Add("Ends", Ends_Element.ToLinkField(context));
members.Add("Shading", Shading_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
members.Add("AbsolutePointOffsets", AbsolutePointOffsets_Element.ToLinkField(context));
members.Add("UVScale", UVScale_Element.ToLinkField(context));
members.Add("ScaleUVByCircumference", ScaleUVByCircumference_Element.ToLinkField(context));
members.Add("PreciseUV", PreciseUV_Element.ToLinkField(context));
members.Add("PointOffsets", PointOffsets.ToLinkArray(context));
members.Add("ColorMode", ColorMode_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("UseTipRotation", UseTipRotation_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("OverrideTip", OverrideTip_Element.ToLinkReference(context));
members.Add("OverrideTipRotation", OverrideTipRotation_Element.ToLinkReference(context));
members.Add("OffsetSpace", OffsetSpace.ToLinkSyncObject(context));
members.Add("RotationSpace", RotationSpace.ToLinkSyncObject(context));
}

}
            }
}
