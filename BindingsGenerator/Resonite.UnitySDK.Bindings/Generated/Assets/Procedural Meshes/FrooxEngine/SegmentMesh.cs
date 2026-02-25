
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SegmentMesh")]
public partial class SegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public UnityEngine.Vector3 PointA;
public UnityEngine.Vector3 PointB;
public global::FrooxEngine.Slot SlotA;
public global::FrooxEngine.Slot SlotB;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("PointA", PointA.ToResoniteLinkField());
members.Add("PointB", PointB.ToResoniteLinkField());
members.Add("SlotA", SlotA.ToResoniteReference(context));
members.Add("SlotB", SlotB.ToResoniteReference(context));
members.Add("Shading", Shading.ToResoniteLinkField());
}

}
}
