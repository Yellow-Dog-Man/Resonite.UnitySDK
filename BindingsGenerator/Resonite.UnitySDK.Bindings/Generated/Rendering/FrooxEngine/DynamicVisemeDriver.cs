
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver
// Generated on: čtvrtek 26. února 2026 15:09:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver")]
public partial class DynamicVisemeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.VisemeAnalyzer Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VisemeAnalyzer>, global::FrooxEngine.VisemeAnalyzer> Source_Element = new();
public global::FrooxEngine.IMouthTrackingSourceComponent MouthTrackingSource { get => MouthTrackingSource_Element.Data; set => MouthTrackingSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>, global::FrooxEngine.IMouthTrackingSourceComponent> MouthTrackingSource_Element = new();
public global::System.Single StrengthMultiplier { get => StrengthMultiplier_Element.Data; set => StrengthMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrengthMultiplier_Element = new();
public global::System.Single VoiceMouthSupressWeight { get => VoiceMouthSupressWeight_Element.Data; set => VoiceMouthSupressWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VoiceMouthSupressWeight_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DynamicVisemeDriver.TargetDriver>, global::FrooxEngine.DynamicVisemeDriver.TargetDriver> Drivers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("MouthTrackingSource", MouthTrackingSource_Element.ToLinkReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier_Element.ToLinkField(context));
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight_Element.ToLinkField(context));
members.Add("Drivers", Drivers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
