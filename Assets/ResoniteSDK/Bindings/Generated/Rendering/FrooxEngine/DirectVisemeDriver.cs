
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DirectVisemeDriver
// Generated on: sobota 14. února 2026 8:58:33
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DirectVisemeDriver")]
public partial class DirectVisemeDriver : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.VisemeAnalyzer Source;
public global::FrooxEngine.IMouthTrackingSourceComponent MouthTrackingSource;
public global::System.Single StrengthMultiplier;
public global::System.Single VoiceMouthSupressWeight;
public global::System.Single LaughThreshold;
public global::System.Single LaughBeginSpeed;
public global::System.Single LaughEndSpeed;
public global::FrooxEngine.IField<global::System.Single> Silence;
public global::FrooxEngine.IField<global::System.Single> PP;
public global::FrooxEngine.IField<global::System.Single> FF;
public global::FrooxEngine.IField<global::System.Single> TH;
public global::FrooxEngine.IField<global::System.Single> DD;
public global::FrooxEngine.IField<global::System.Single> kk;
public global::FrooxEngine.IField<global::System.Single> CH;
public global::FrooxEngine.IField<global::System.Single> SS;
public global::FrooxEngine.IField<global::System.Single> nn;
public global::FrooxEngine.IField<global::System.Single> RR;
public global::FrooxEngine.IField<global::System.Single> aa;
public global::FrooxEngine.IField<global::System.Single> E;
public global::FrooxEngine.IField<global::System.Single> ih;
public global::FrooxEngine.IField<global::System.Single> oh;
public global::FrooxEngine.IField<global::System.Single> ou;
public global::FrooxEngine.IField<global::System.Single> Laugh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("MouthTrackingSource", MouthTrackingSource.ToResoniteReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight.ToResoniteLinkField());
members.Add("LaughThreshold", LaughThreshold.ToResoniteLinkField());
members.Add("LaughBeginSpeed", LaughBeginSpeed.ToResoniteLinkField());
members.Add("LaughEndSpeed", LaughEndSpeed.ToResoniteLinkField());
members.Add("Silence", Silence.ToResoniteReference(context));
members.Add("PP", PP.ToResoniteReference(context));
members.Add("FF", FF.ToResoniteReference(context));
members.Add("TH", TH.ToResoniteReference(context));
members.Add("DD", DD.ToResoniteReference(context));
members.Add("kk", kk.ToResoniteReference(context));
members.Add("CH", CH.ToResoniteReference(context));
members.Add("SS", SS.ToResoniteReference(context));
members.Add("nn", nn.ToResoniteReference(context));
members.Add("RR", RR.ToResoniteReference(context));
members.Add("aa", aa.ToResoniteReference(context));
members.Add("E", E.ToResoniteReference(context));
members.Add("ih", ih.ToResoniteReference(context));
members.Add("oh", oh.ToResoniteReference(context));
members.Add("ou", ou.ToResoniteReference(context));
members.Add("Laugh", Laugh.ToResoniteReference(context));
}

}
}
