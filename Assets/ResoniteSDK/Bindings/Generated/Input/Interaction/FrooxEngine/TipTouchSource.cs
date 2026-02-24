
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TipTouchSource
// Generated on: úterý 24. února 2026 18:17:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TipTouchSource")]
public partial class TipTouchSource : global::FrooxEngine.RaycastTouchSource

{
    public global::System.Boolean UseUserSpaceForDistance;
public global::System.Single TouchDistance;
public global::System.Single MaxDistance;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Direction;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseUserSpaceForDistance", UseUserSpaceForDistance.ToResoniteLinkField());
members.Add("TouchDistance", TouchDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
}

}
}
