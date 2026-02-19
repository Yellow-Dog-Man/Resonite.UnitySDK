
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BentTubeMesh
// Generated on: čtvrtek 19. února 2026 7:58:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BentTubeMesh")]
public partial class BentTubeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::System.Int32 Sides;
public global::System.Int32 Segments;
public UnityEngine.Vector3 StartPoint;
public UnityEngine.Vector3 DirectTargetPoint;
public UnityEngine.Vector3 ActualTargetPoint;
public UnityEngine.ColorX StartPointColor;
public UnityEngine.ColorX EndPointColor;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("StartPoint", StartPoint.ToResoniteLinkField());
members.Add("DirectTargetPoint", DirectTargetPoint.ToResoniteLinkField());
members.Add("ActualTargetPoint", ActualTargetPoint.ToResoniteLinkField());
members.Add("StartPointColor", StartPointColor.ToResoniteLinkField());
members.Add("EndPointColor", EndPointColor.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
}

}
}
