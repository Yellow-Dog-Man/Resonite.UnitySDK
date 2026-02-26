
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurvedPlaneMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurvedPlaneMesh")]
public partial class CurvedPlaneMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector2 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Size_Element = new();
public global::System.Single Curvature { get => Curvature_Element.Data; set => Curvature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Curvature_Element = new();
public global::System.Single TiltAngle { get => TiltAngle_Element.Data; set => TiltAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TiltAngle_Element = new();
public global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation AspectRatioCompensation { get => AspectRatioCompensation_Element.Data; set => AspectRatioCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation>, global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation> AspectRatioCompensation_Element = new();
public UnityEngine.Vector2 UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVScale_Element = new();
public UnityEngine.Vector2 UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> UVOffset_Element = new();
public global::System.Int32 Segments { get => Segments_Element.Data; set => Segments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Segments_Element = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("Curvature", Curvature_Element.Data.ToResoniteLinkField());
members.Add("TiltAngle", TiltAngle_Element.Data.ToResoniteLinkField());
members.Add("AspectRatioCompensation", AspectRatioCompensation_Element.Data.ToResoniteLinkField());
members.Add("UVScale", UVScale_Element.Data.ToResoniteLinkField());
members.Add("UVOffset", UVOffset_Element.Data.ToResoniteLinkField());
members.Add("Segments", Segments_Element.Data.ToResoniteLinkField());
members.Add("FlatShading", FlatShading_Element.Data.ToResoniteLinkField());
}

}
}
