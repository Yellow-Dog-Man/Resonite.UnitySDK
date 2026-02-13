
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeWireMesh
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeWireMesh")]
public partial class TubeWireMesh : global::FrooxEngine.WireMeshBase

{
    public global::System.Single Radius0;
public global::System.Single Radius1;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;
public global::System.Int32 Points;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius0", Radius0.ToResoniteLinkField());
members.Add("Radius1", Radius1.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
}

}
}
