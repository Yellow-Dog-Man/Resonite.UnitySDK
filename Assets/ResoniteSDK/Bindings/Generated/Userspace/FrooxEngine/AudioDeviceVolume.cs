
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioDeviceVolume
// Generated on: pátek 13. února 2026 5:52:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioDeviceVolume")]
public partial class AudioDeviceVolume : global::FrooxEngine.Component

{
    public global::System.Int32 AudioDeviceIndex;
public global::System.Single Volume;
public global::System.Single NormalizedVolume;
public global::System.Single Smoothing;
public global::System.Single Power;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AudioDeviceIndex", AudioDeviceIndex.ToResoniteLinkField());
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("NormalizedVolume", NormalizedVolume.ToResoniteLinkField());
members.Add("Smoothing", Smoothing.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
}

}
}
