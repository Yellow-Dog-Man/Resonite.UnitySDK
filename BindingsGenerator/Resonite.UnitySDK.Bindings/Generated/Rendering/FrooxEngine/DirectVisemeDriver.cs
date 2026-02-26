
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DirectVisemeDriver
// Generated on: čtvrtek 26. února 2026 12:28:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DirectVisemeDriver")]
public partial class DirectVisemeDriver : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.VisemeAnalyzer Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.VisemeAnalyzer>, global::FrooxEngine.VisemeAnalyzer> Source_Element = new();
public global::FrooxEngine.IMouthTrackingSourceComponent MouthTrackingSource { get => MouthTrackingSource_Element.Data; set => MouthTrackingSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>, global::FrooxEngine.IMouthTrackingSourceComponent> MouthTrackingSource_Element = new();
public global::System.Single StrengthMultiplier { get => StrengthMultiplier_Element.Data; set => StrengthMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrengthMultiplier_Element = new();
public global::System.Single VoiceMouthSupressWeight { get => VoiceMouthSupressWeight_Element.Data; set => VoiceMouthSupressWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VoiceMouthSupressWeight_Element = new();
public global::System.Single LaughThreshold { get => LaughThreshold_Element.Data; set => LaughThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LaughThreshold_Element = new();
public global::System.Single LaughBeginSpeed { get => LaughBeginSpeed_Element.Data; set => LaughBeginSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LaughBeginSpeed_Element = new();
public global::System.Single LaughEndSpeed { get => LaughEndSpeed_Element.Data; set => LaughEndSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LaughEndSpeed_Element = new();
public global::FrooxEngine.IField<global::System.Single> Silence { get => Silence_Element.Data; set => Silence_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Silence_Element = new();
public global::FrooxEngine.IField<global::System.Single> PP { get => PP_Element.Data; set => PP_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> PP_Element = new();
public global::FrooxEngine.IField<global::System.Single> FF { get => FF_Element.Data; set => FF_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> FF_Element = new();
public global::FrooxEngine.IField<global::System.Single> TH { get => TH_Element.Data; set => TH_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> TH_Element = new();
public global::FrooxEngine.IField<global::System.Single> DD { get => DD_Element.Data; set => DD_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> DD_Element = new();
public global::FrooxEngine.IField<global::System.Single> kk { get => kk_Element.Data; set => kk_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> kk_Element = new();
public global::FrooxEngine.IField<global::System.Single> CH { get => CH_Element.Data; set => CH_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> CH_Element = new();
public global::FrooxEngine.IField<global::System.Single> SS { get => SS_Element.Data; set => SS_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> SS_Element = new();
public global::FrooxEngine.IField<global::System.Single> nn { get => nn_Element.Data; set => nn_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> nn_Element = new();
public global::FrooxEngine.IField<global::System.Single> RR { get => RR_Element.Data; set => RR_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> RR_Element = new();
public global::FrooxEngine.IField<global::System.Single> aa { get => aa_Element.Data; set => aa_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> aa_Element = new();
public global::FrooxEngine.IField<global::System.Single> E { get => E_Element.Data; set => E_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> E_Element = new();
public global::FrooxEngine.IField<global::System.Single> ih { get => ih_Element.Data; set => ih_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> ih_Element = new();
public global::FrooxEngine.IField<global::System.Single> oh { get => oh_Element.Data; set => oh_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> oh_Element = new();
public global::FrooxEngine.IField<global::System.Single> ou { get => ou_Element.Data; set => ou_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> ou_Element = new();
public global::FrooxEngine.IField<global::System.Single> Laugh { get => Laugh_Element.Data; set => Laugh_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Laugh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("MouthTrackingSource", MouthTrackingSource_Element.ToLinkReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier_Element.ToLinkField(context));
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight_Element.ToLinkField(context));
members.Add("LaughThreshold", LaughThreshold_Element.ToLinkField(context));
members.Add("LaughBeginSpeed", LaughBeginSpeed_Element.ToLinkField(context));
members.Add("LaughEndSpeed", LaughEndSpeed_Element.ToLinkField(context));
members.Add("Silence", Silence_Element.ToLinkReference(context));
members.Add("PP", PP_Element.ToLinkReference(context));
members.Add("FF", FF_Element.ToLinkReference(context));
members.Add("TH", TH_Element.ToLinkReference(context));
members.Add("DD", DD_Element.ToLinkReference(context));
members.Add("kk", kk_Element.ToLinkReference(context));
members.Add("CH", CH_Element.ToLinkReference(context));
members.Add("SS", SS_Element.ToLinkReference(context));
members.Add("nn", nn_Element.ToLinkReference(context));
members.Add("RR", RR_Element.ToLinkReference(context));
members.Add("aa", aa_Element.ToLinkReference(context));
members.Add("E", E_Element.ToLinkReference(context));
members.Add("ih", ih_Element.ToLinkReference(context));
members.Add("oh", oh_Element.ToLinkReference(context));
members.Add("ou", ou_Element.ToLinkReference(context));
members.Add("Laugh", Laugh_Element.ToLinkReference(context));
}

}
}
