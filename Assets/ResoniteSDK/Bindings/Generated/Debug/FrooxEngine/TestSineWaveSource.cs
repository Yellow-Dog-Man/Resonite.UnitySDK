
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TestSineWaveSource
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TestSineWaveSource")]
public partial class TestSineWaveSource : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Single Frequency;
public global::System.Single Amplitude;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Frequency", Frequency.ToResoniteLinkField());
members.Add("Amplitude", Amplitude.ToResoniteLinkField());
}

}
}
