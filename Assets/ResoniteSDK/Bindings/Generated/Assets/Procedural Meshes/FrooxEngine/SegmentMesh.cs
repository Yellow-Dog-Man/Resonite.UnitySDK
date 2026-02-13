
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SegmentMesh")]
public partial class SegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public UnityEngine.Vector3 PointA;
public UnityEngine.Vector3 PointB;
public global::FrooxEngine.Slot SlotA;
public global::FrooxEngine.Slot SlotB;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("PointA", PointA.ToResoniteLinkField());
members.Add("PointB", PointB.ToResoniteLinkField());
members.Add("SlotA", new ResoniteLink.Reference() { });
members.Add("SlotB", new ResoniteLink.Reference() { });
members.Add("Shading", Shading.ToResoniteLinkField());
}

}
}
