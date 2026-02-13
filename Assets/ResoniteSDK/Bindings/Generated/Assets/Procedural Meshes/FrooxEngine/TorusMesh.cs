
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorusMesh
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TorusMesh")]
public partial class TorusMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 MinorSegments;
public global::System.Int32 MajorSegments;
public global::System.Single MajorRadius;
public global::System.Single MinorRadius;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinorSegments", MinorSegments.ToResoniteLinkField());
members.Add("MajorSegments", MajorSegments.ToResoniteLinkField());
members.Add("MajorRadius", MajorRadius.ToResoniteLinkField());
members.Add("MinorRadius", MinorRadius.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
