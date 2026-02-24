
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorusMesh
// Generated on: úterý 24. února 2026 18:17:41
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinorSegments", MinorSegments.ToResoniteLinkField());
members.Add("MajorSegments", MajorSegments.ToResoniteLinkField());
members.Add("MajorRadius", MajorRadius.ToResoniteLinkField());
members.Add("MinorRadius", MinorRadius.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
