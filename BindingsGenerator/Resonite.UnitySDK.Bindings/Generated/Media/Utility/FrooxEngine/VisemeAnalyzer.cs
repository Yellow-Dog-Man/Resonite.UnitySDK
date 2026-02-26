
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VisemeAnalyzer
// Generated on: čtvrtek 26. února 2026 12:26:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VisemeAnalyzer")]
public partial class VisemeAnalyzer : global::FrooxEngine.Component

{
    public global::FrooxEngine.IWorldAudioDataSource Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>, global::FrooxEngine.IWorldAudioDataSource> Source_Element = new();
public global::FrooxEngine.MultiValueStream<global::System.Single> RemoteSource { get => RemoteSource_Element.Data; set => RemoteSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MultiValueStream<global::System.Single>>, global::FrooxEngine.MultiValueStream<global::System.Single>> RemoteSource_Element = new();
public global::FrooxEngine.VisemeAnalyzerEngine PreferredAnalyzer { get => PreferredAnalyzer_Element.Data; set => PreferredAnalyzer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VisemeAnalyzerEngine>, global::FrooxEngine.VisemeAnalyzerEngine> PreferredAnalyzer_Element = new();
public global::System.Single Smoothing { get => Smoothing_Element.Data; set => Smoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothing_Element = new();
public global::System.Single Silence { get => Silence_Element.Data; set => Silence_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> Silence_Element = new();
public global::System.Single PP { get => PP_Element.Data; set => PP_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> PP_Element = new();
public global::System.Single FF { get => FF_Element.Data; set => FF_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> FF_Element = new();
public global::System.Single TH { get => TH_Element.Data; set => TH_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> TH_Element = new();
public global::System.Single DD { get => DD_Element.Data; set => DD_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> DD_Element = new();
public global::System.Single kk { get => kk_Element.Data; set => kk_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> kk_Element = new();
public global::System.Single CH { get => CH_Element.Data; set => CH_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CH_Element = new();
public global::System.Single SS { get => SS_Element.Data; set => SS_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> SS_Element = new();
public global::System.Single nn { get => nn_Element.Data; set => nn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> nn_Element = new();
public global::System.Single RR { get => RR_Element.Data; set => RR_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RR_Element = new();
public global::System.Single aa { get => aa_Element.Data; set => aa_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> aa_Element = new();
public global::System.Single E { get => E_Element.Data; set => E_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> E_Element = new();
public global::System.Single ih { get => ih_Element.Data; set => ih_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ih_Element = new();
public global::System.Single oh { get => oh_Element.Data; set => oh_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> oh_Element = new();
public global::System.Single ou { get => ou_Element.Data; set => ou_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ou_Element = new();
public global::System.Single LaughterProbability { get => LaughterProbability_Element.Data; set => LaughterProbability_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LaughterProbability_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("RemoteSource", RemoteSource_Element.ToLinkReference(context));
members.Add("PreferredAnalyzer", PreferredAnalyzer_Element.ToLinkField(context));
members.Add("Smoothing", Smoothing_Element.ToLinkField(context));
members.Add("Silence", Silence_Element.ToLinkField(context));
members.Add("PP", PP_Element.ToLinkField(context));
members.Add("FF", FF_Element.ToLinkField(context));
members.Add("TH", TH_Element.ToLinkField(context));
members.Add("DD", DD_Element.ToLinkField(context));
members.Add("kk", kk_Element.ToLinkField(context));
members.Add("CH", CH_Element.ToLinkField(context));
members.Add("SS", SS_Element.ToLinkField(context));
members.Add("nn", nn_Element.ToLinkField(context));
members.Add("RR", RR_Element.ToLinkField(context));
members.Add("aa", aa_Element.ToLinkField(context));
members.Add("E", E_Element.ToLinkField(context));
members.Add("ih", ih_Element.ToLinkField(context));
members.Add("oh", oh_Element.ToLinkField(context));
members.Add("ou", ou_Element.ToLinkField(context));
members.Add("LaughterProbability", LaughterProbability_Element.ToLinkField(context));
}

}
}
