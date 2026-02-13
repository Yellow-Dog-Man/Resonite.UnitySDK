
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotSegmentMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotSegmentMesh")]
public partial class SlotSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::FrooxEngine.Slot PointA;
public global::FrooxEngine.Slot PointB;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("PointA", new ResoniteLink.Reference() { });
members.Add("PointB", new ResoniteLink.Reference() { });
}

}
}
