
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchSource
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchSource")]
public abstract partial class TouchSource : global::FrooxEngine.Component

{
    public global::FrooxEngine.User AutoUpdateUser;
public global::System.Single OutOfSightAngle;
public global::System.Single MaxTouchPenetrationDistance;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AutoUpdateUser", new ResoniteLink.Reference() { });
members.Add("OutOfSightAngle", OutOfSightAngle.ToResoniteLinkField());
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance.ToResoniteLinkField());
}

}
}
