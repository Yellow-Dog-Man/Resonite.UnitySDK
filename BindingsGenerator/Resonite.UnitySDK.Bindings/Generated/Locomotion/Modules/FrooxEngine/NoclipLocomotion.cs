
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoclipLocomotion
// Generated on: čtvrtek 26. února 2026 12:26:56
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoclipLocomotion")]
public partial class NoclipLocomotion : global::FrooxEngine.SmoothLocomotionBase

{
    public global::FrooxEngine.TurnSubmodule Turn = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public global::System.Single MinimumFlySpeedRatio { get => MinimumFlySpeedRatio_Element.Data; set => MinimumFlySpeedRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumFlySpeedRatio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Turn", Turn.ToLinkSyncObject(context));
members.Add("MaxSpeed", MaxSpeed_Element.ToLinkField(context));
members.Add("MinimumFlySpeedRatio", MinimumFlySpeedRatio_Element.ToLinkField(context));
}

}
}
