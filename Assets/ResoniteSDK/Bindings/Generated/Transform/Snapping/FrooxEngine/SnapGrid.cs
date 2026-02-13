
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapGrid
// Generated on: pátek 13. února 2026 5:52:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapGrid")]
public partial class SnapGrid : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public UnityEngine.Vector3 BoundsSize;
public UnityEngine.Vector3 GridSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderSize;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BoundsSize", BoundsSize.ToResoniteLinkField());
members.Add("GridSize", GridSize.ToResoniteLinkField());
members.Add("ColliderSize", new ResoniteLink.Reference() { });
members.Add("SnapParent", new ResoniteLink.Reference() { });
}

}
}
