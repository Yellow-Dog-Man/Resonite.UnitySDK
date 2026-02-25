
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchSource
// Generated on: středa 25. února 2026 16:13:09
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
