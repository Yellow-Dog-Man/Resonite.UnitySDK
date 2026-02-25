
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvexHullMesh
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConvexHullMesh")]
public partial class ConvexHullMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3[] Points;
public global::System.Boolean FlatShading;
public global::System.Double MinVertexDistance;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToResoniteLinkArray());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("MinVertexDistance", MinVertexDistance.ToResoniteLinkField());
}

}
}
