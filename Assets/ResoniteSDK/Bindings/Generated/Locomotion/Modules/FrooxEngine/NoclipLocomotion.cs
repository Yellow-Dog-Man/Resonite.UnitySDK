
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoclipLocomotion
// Generated on: pátek 13. února 2026 23:21:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoclipLocomotion")]
public partial class NoclipLocomotion : global::FrooxEngine.SmoothLocomotionBase

{
    public global::FrooxEngine.TurnSubmodule Turn;
public global::System.Single MaxSpeed;
public global::System.Single MinimumFlySpeedRatio;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers() });
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("MinimumFlySpeedRatio", MinimumFlySpeedRatio.ToResoniteLinkField());
}

}
}
