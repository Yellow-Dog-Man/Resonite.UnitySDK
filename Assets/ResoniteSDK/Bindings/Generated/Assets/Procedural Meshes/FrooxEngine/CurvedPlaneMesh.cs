
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurvedPlaneMesh
// Generated on: čtvrtek 19. února 2026 7:58:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurvedPlaneMesh")]
public partial class CurvedPlaneMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector2 Size;
public global::System.Single Curvature;
public global::System.Single TiltAngle;
public global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation AspectRatioCompensation;
public UnityEngine.Vector2 UVScale;
public UnityEngine.Vector2 UVOffset;
public global::System.Int32 Segments;
public global::System.Boolean FlatShading;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Curvature", Curvature.ToResoniteLinkField());
members.Add("TiltAngle", TiltAngle.ToResoniteLinkField());
members.Add("AspectRatioCompensation", AspectRatioCompensation.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
}

}
}
