
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioDeviceVolume
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Int32 AudioDeviceIndex { get => AudioDeviceIndex_Element.Data; set => AudioDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AudioDeviceIndex_Element = new();
public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Volume_Element = new();
public global::System.Single NormalizedVolume { get => NormalizedVolume_Element.Data; set => NormalizedVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedVolume_Element = new();
public global::System.Single Smoothing { get => Smoothing_Element.Data; set => Smoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothing_Element = new();
public global::System.Single Power { get => Power_Element.Data; set => Power_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Power_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioDeviceIndex", AudioDeviceIndex_Element.ToLinkField(context));
members.Add("Volume", Volume_Element.ToLinkField(context));
members.Add("NormalizedVolume", NormalizedVolume_Element.ToLinkField(context));
members.Add("Smoothing", Smoothing_Element.ToLinkField(context));
members.Add("Power", Power_Element.ToLinkField(context));
}

}
}
