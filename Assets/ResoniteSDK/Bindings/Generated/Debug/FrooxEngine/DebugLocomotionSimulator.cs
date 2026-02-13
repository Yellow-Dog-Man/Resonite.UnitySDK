
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLocomotionSimulator
// Generated on: pátek 13. února 2026 5:51:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLocomotionSimulator")]
public partial class DebugLocomotionSimulator : global::FrooxEngine.Component

{
    public global::System.Boolean TrackPosition;
public global::FrooxEngine.LocomotionState State;
public UnityEngine.Vector3 MovementSpeed;
public global::System.Single AngularSpeed;
public global::System.Boolean RotateDirection;
public global::System.Boolean OffsetRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TrackPosition", TrackPosition.ToResoniteLinkField());
members.Add("State", State.ToResoniteLinkField());
members.Add("MovementSpeed", MovementSpeed.ToResoniteLinkField());
members.Add("AngularSpeed", AngularSpeed.ToResoniteLinkField());
members.Add("RotateDirection", RotateDirection.ToResoniteLinkField());
members.Add("OffsetRoot", OffsetRoot.ToResoniteLinkField());
}

}
}
