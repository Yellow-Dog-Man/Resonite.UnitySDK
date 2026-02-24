
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoclipLocomotion
// Generated on: úterý 24. února 2026 18:17:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoclipLocomotion")]
public partial class NoclipLocomotion : global::FrooxEngine.SmoothLocomotionBase

{
    public global::FrooxEngine.TurnSubmodule Turn;
public global::System.Single MaxSpeed;
public global::System.Single MinimumFlySpeedRatio;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", new ResoniteLink.SyncObject() { Members = Turn.CollectMembers(context) });
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("MinimumFlySpeedRatio", MinimumFlySpeedRatio.ToResoniteLinkField());
}

}
}
