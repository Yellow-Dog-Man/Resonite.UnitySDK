
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioZitaReverb
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioZitaReverb")]
public partial class AudioZitaReverb : global::FrooxEngine.AudioDSP_Effect, global::SharpPipe.IZitaFilter, global::FrooxEngine.ICustomInspector

{
    public global::System.Single InDelay { get => InDelay_Element.Data; set => InDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InDelay_Element = new();
public global::System.Single Crossover { get => Crossover_Element.Data; set => Crossover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Crossover_Element = new();
public global::System.Single RT60Low { get => RT60Low_Element.Data; set => RT60Low_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RT60Low_Element = new();
public global::System.Single RT60Mid { get => RT60Mid_Element.Data; set => RT60Mid_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RT60Mid_Element = new();
public global::System.Single HighFrequencyDamping { get => HighFrequencyDamping_Element.Data; set => HighFrequencyDamping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HighFrequencyDamping_Element = new();
public global::System.Single EQ1Frequency { get => EQ1Frequency_Element.Data; set => EQ1Frequency_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EQ1Frequency_Element = new();
public global::System.Single EQ1Level { get => EQ1Level_Element.Data; set => EQ1Level_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EQ1Level_Element = new();
public global::System.Single EQ2Frequency { get => EQ2Frequency_Element.Data; set => EQ2Frequency_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EQ2Frequency_Element = new();
public global::System.Single EQ2Level { get => EQ2Level_Element.Data; set => EQ2Level_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EQ2Level_Element = new();
public global::System.Single Mix { get => Mix_Element.Data; set => Mix_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Mix_Element = new();
public global::System.Single Level { get => Level_Element.Data; set => Level_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Level_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InDelay", InDelay_Element.ToLinkField(context));
members.Add("Crossover", Crossover_Element.ToLinkField(context));
members.Add("RT60Low", RT60Low_Element.ToLinkField(context));
members.Add("RT60Mid", RT60Mid_Element.ToLinkField(context));
members.Add("HighFrequencyDamping", HighFrequencyDamping_Element.ToLinkField(context));
members.Add("EQ1Frequency", EQ1Frequency_Element.ToLinkField(context));
members.Add("EQ1Level", EQ1Level_Element.ToLinkField(context));
members.Add("EQ2Frequency", EQ2Frequency_Element.ToLinkField(context));
members.Add("EQ2Level", EQ2Level_Element.ToLinkField(context));
members.Add("Mix", Mix_Element.ToLinkField(context));
members.Add("Level", Level_Element.ToLinkField(context));
}

}
}
