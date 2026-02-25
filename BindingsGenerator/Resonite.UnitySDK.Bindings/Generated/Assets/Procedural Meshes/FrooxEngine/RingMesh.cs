
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RingMesh
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RingMesh")]
public partial class RingMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Rotation;
public global::System.Int32 Segments;
public global::System.Single Arc;
public global::System.Single InnerRadius;
public global::System.Single OuterRadius;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("InnerRadius", InnerRadius.ToResoniteLinkField());
members.Add("OuterRadius", OuterRadius.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
