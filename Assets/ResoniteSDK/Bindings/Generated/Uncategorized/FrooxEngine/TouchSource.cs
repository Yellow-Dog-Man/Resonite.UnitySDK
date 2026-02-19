
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchSource
// Generated on: čtvrtek 19. února 2026 7:58:59
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdateUser", AutoUpdateUser.ToResoniteReference(context));
members.Add("OutOfSightAngle", OutOfSightAngle.ToResoniteLinkField());
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance.ToResoniteLinkField());
}

}
}
