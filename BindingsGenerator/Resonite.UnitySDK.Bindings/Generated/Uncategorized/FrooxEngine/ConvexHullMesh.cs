
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvexHullMesh
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConvexHullMesh")]
public partial class ConvexHullMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncArray<global::FrooxEngine.SyncArray<UnityEngine.Vector3>, UnityEngine.Vector3> Points = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();
public global::System.Double MinVertexDistance { get => MinVertexDistance_Element.Data; set => MinVertexDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> MinVertexDistance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToLinkArray(context));
members.Add("FlatShading", FlatShading_Element.ToLinkField(context));
members.Add("MinVertexDistance", MinVertexDistance_Element.ToLinkField(context));
}

}
}
