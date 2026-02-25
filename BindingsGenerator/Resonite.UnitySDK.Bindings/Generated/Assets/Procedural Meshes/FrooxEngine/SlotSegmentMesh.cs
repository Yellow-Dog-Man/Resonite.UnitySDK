
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotSegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotSegmentMesh")]
public partial class SlotSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::FrooxEngine.Slot PointA;
public global::FrooxEngine.Slot PointB;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("PointA", PointA.ToResoniteReference(context));
members.Add("PointB", PointB.ToResoniteReference(context));
}

}
}
