
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TestSineWaveSource
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TestSineWaveSource")]
public partial class TestSineWaveSource : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Single Frequency { get => Frequency_Element.Data; set => Frequency_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Frequency_Element = new();
public global::System.Single Amplitude { get => Amplitude_Element.Data; set => Amplitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Amplitude_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Frequency", Frequency_Element.ToLinkField(context));
members.Add("Amplitude", Amplitude_Element.ToLinkField(context));
}

}
}
