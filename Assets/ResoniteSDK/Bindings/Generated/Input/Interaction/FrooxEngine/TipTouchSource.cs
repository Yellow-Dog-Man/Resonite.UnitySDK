
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TipTouchSource
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TipTouchSource")]
public partial class TipTouchSource : global::FrooxEngine.RaycastTouchSource

{
    public global::System.Boolean UseUserSpaceForDistance;
public global::System.Single TouchDistance;
public global::System.Single MaxDistance;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Direction;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseUserSpaceForDistance", UseUserSpaceForDistance.ToResoniteLinkField());
members.Add("TouchDistance", TouchDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
}

}
}
