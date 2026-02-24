
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLocomotionSimulator
// Generated on: úterý 24. února 2026 18:17:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLocomotionSimulator")]
public partial class DebugLocomotionSimulator : global::FrooxEngine.Component

{
    public global::System.Boolean TrackPosition;
public global::FrooxEngine.LocomotionState State;
public UnityEngine.Vector3 MovementSpeed;
public global::System.Single AngularSpeed;
public global::System.Boolean RotateDirection;
public global::System.Boolean OffsetRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TrackPosition", TrackPosition.ToResoniteLinkField());
members.Add("State", State.ToResoniteLinkField());
members.Add("MovementSpeed", MovementSpeed.ToResoniteLinkField());
members.Add("AngularSpeed", AngularSpeed.ToResoniteLinkField());
members.Add("RotateDirection", RotateDirection.ToResoniteLinkField());
members.Add("OffsetRoot", OffsetRoot.ToResoniteLinkField());
}

}
}
