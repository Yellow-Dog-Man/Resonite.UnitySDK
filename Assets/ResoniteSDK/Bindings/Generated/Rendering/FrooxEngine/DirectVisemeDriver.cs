
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DirectVisemeDriver
// Generated on: pátek 13. února 2026 23:23:04
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("MouthTrackingSource", new ResoniteLink.Reference() { });
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight.ToResoniteLinkField());
members.Add("LaughThreshold", LaughThreshold.ToResoniteLinkField());
members.Add("LaughBeginSpeed", LaughBeginSpeed.ToResoniteLinkField());
members.Add("LaughEndSpeed", LaughEndSpeed.ToResoniteLinkField());
members.Add("Silence", new ResoniteLink.Reference() { });
members.Add("PP", new ResoniteLink.Reference() { });
members.Add("FF", new ResoniteLink.Reference() { });
members.Add("TH", new ResoniteLink.Reference() { });
members.Add("DD", new ResoniteLink.Reference() { });
members.Add("kk", new ResoniteLink.Reference() { });
members.Add("CH", new ResoniteLink.Reference() { });
members.Add("SS", new ResoniteLink.Reference() { });
members.Add("nn", new ResoniteLink.Reference() { });
members.Add("RR", new ResoniteLink.Reference() { });
members.Add("aa", new ResoniteLink.Reference() { });
members.Add("E", new ResoniteLink.Reference() { });
members.Add("ih", new ResoniteLink.Reference() { });
members.Add("oh", new ResoniteLink.Reference() { });
members.Add("ou", new ResoniteLink.Reference() { });
members.Add("Laugh", new ResoniteLink.Reference() { });
}

}
}
