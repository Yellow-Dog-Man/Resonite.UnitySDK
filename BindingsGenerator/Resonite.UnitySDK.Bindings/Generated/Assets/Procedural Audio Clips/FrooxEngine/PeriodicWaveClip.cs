
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PeriodicWaveClip
// Generated on: pondělí 2. března 2026 17:52:24
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PeriodicWaveClip")]
public abstract partial class PeriodicWaveClip : global::FrooxEngine.ProceduralAudioClip

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
