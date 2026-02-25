
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VisemeAnalyzer
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.IWorldAudioDataSource Source;
public global::FrooxEngine.MultiValueStream<global::System.Single> RemoteSource;
public global::FrooxEngine.VisemeAnalyzerEngine PreferredAnalyzer;
public global::System.Single Smoothing;
public global::System.Single Silence;
public global::System.Single PP;
public global::System.Single FF;
public global::System.Single TH;
public global::System.Single DD;
public global::System.Single kk;
public global::System.Single CH;
public global::System.Single SS;
public global::System.Single nn;
public global::System.Single RR;
public global::System.Single aa;
public global::System.Single E;
public global::System.Single ih;
public global::System.Single oh;
public global::System.Single ou;
public global::System.Single LaughterProbability;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("RemoteSource", RemoteSource.ToResoniteReference(context));
members.Add("PreferredAnalyzer", PreferredAnalyzer.ToResoniteLinkField());
members.Add("Smoothing", Smoothing.ToResoniteLinkField());
members.Add("Silence", Silence.ToResoniteLinkField());
members.Add("PP", PP.ToResoniteLinkField());
members.Add("FF", FF.ToResoniteLinkField());
members.Add("TH", TH.ToResoniteLinkField());
members.Add("DD", DD.ToResoniteLinkField());
members.Add("kk", kk.ToResoniteLinkField());
members.Add("CH", CH.ToResoniteLinkField());
members.Add("SS", SS.ToResoniteLinkField());
members.Add("nn", nn.ToResoniteLinkField());
members.Add("RR", RR.ToResoniteLinkField());
members.Add("aa", aa.ToResoniteLinkField());
members.Add("E", E.ToResoniteLinkField());
members.Add("ih", ih.ToResoniteLinkField());
members.Add("oh", oh.ToResoniteLinkField());
members.Add("ou", ou.ToResoniteLinkField());
members.Add("LaughterProbability", LaughterProbability.ToResoniteLinkField());
}

}
}
