
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.TimeProximityRibbonSplitter
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.TimeProximityRibbonSplitter")]
public partial class TimeProximityRibbonSplitter : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single Interval { get => Interval_Element.Data; set => Interval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Interval_Element = new();
public global::PhotonDust.TimeSplitMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.TimeSplitMode>, global::PhotonDust.TimeSplitMode> Mode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Interval", Interval_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
}

}
}
