
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioZitaReverb
// Generated on: pátek 13. února 2026 5:51:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioZitaReverb")]
public partial class AudioZitaReverb : global::FrooxEngine.AudioDSP_Effect, global::SharpPipe.IZitaFilter, global::FrooxEngine.ICustomInspector

{
    public global::System.Single InDelay;
public global::System.Single Crossover;
public global::System.Single RT60Low;
public global::System.Single RT60Mid;
public global::System.Single HighFrequencyDamping;
public global::System.Single EQ1Frequency;
public global::System.Single EQ1Level;
public global::System.Single EQ2Frequency;
public global::System.Single EQ2Level;
public global::System.Single Mix;
public global::System.Single Level;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InDelay", InDelay.ToResoniteLinkField());
members.Add("Crossover", Crossover.ToResoniteLinkField());
members.Add("RT60Low", RT60Low.ToResoniteLinkField());
members.Add("RT60Mid", RT60Mid.ToResoniteLinkField());
members.Add("HighFrequencyDamping", HighFrequencyDamping.ToResoniteLinkField());
members.Add("EQ1Frequency", EQ1Frequency.ToResoniteLinkField());
members.Add("EQ1Level", EQ1Level.ToResoniteLinkField());
members.Add("EQ2Frequency", EQ2Frequency.ToResoniteLinkField());
members.Add("EQ2Level", EQ2Level.ToResoniteLinkField());
members.Add("Mix", Mix.ToResoniteLinkField());
members.Add("Level", Level.ToResoniteLinkField());
}

}
}
