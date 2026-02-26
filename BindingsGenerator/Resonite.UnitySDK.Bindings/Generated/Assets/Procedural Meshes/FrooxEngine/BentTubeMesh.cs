
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BentTubeMesh
// Generated on: čtvrtek 26. února 2026 10:03:35
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BentTubeMesh")]
public partial class BentTubeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Int32 Sides { get => Sides_Element.Data; set => Sides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Sides_Element = new();
public global::System.Int32 Segments { get => Segments_Element.Data; set => Segments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Segments_Element = new();
public UnityEngine.Vector3 StartPoint { get => StartPoint_Element.Data; set => StartPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> StartPoint_Element = new();
public UnityEngine.Vector3 DirectTargetPoint { get => DirectTargetPoint_Element.Data; set => DirectTargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> DirectTargetPoint_Element = new();
public UnityEngine.Vector3 ActualTargetPoint { get => ActualTargetPoint_Element.Data; set => ActualTargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ActualTargetPoint_Element = new();
public UnityEngine.ColorX StartPointColor { get => StartPointColor_Element.Data; set => StartPointColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> StartPointColor_Element = new();
public UnityEngine.ColorX EndPointColor { get => EndPointColor_Element.Data; set => EndPointColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EndPointColor_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.Data.ToResoniteLinkField());
members.Add("Sides", Sides_Element.Data.ToResoniteLinkField());
members.Add("Segments", Segments_Element.Data.ToResoniteLinkField());
members.Add("StartPoint", StartPoint_Element.Data.ToResoniteLinkField());
members.Add("DirectTargetPoint", DirectTargetPoint_Element.Data.ToResoniteLinkField());
members.Add("ActualTargetPoint", ActualTargetPoint_Element.Data.ToResoniteLinkField());
members.Add("StartPointColor", StartPointColor_Element.Data.ToResoniteLinkField());
members.Add("EndPointColor", EndPointColor_Element.Data.ToResoniteLinkField());
members.Add("Ends", Ends_Element.Data.ToResoniteLinkField());
members.Add("Shading", Shading_Element.Data.ToResoniteLinkField());
}

}
}
