
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointTouchSource
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointTouchSource")]
public partial class PointTouchSource : global::FrooxEngine.RaycastTouchSource

{
    public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Direction;
public global::System.Single MaxDistance;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
}

}
}
