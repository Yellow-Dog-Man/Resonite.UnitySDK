
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IcoSphereMesh
// Generated on: pátek 13. února 2026 5:51:08
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IcoSphereMesh")]
public partial class IcoSphereMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::System.Int32 Subdivisions;
public global::System.Boolean FlatShading;
public global::System.Single FlatFaceExtrude;
public global::System.Single FlatFaceScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Subdivisions", Subdivisions.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("FlatFaceExtrude", FlatFaceExtrude.ToResoniteLinkField());
members.Add("FlatFaceScale", FlatFaceScale.ToResoniteLinkField());
}

}
}
