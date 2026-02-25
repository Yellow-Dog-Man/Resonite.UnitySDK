
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver
// Generated on: středa 25. února 2026 16:14:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver")]
public partial class DynamicVisemeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.VisemeAnalyzer Source;
public global::FrooxEngine.IMouthTrackingSourceComponent MouthTrackingSource;
public global::System.Single StrengthMultiplier;
public global::System.Single VoiceMouthSupressWeight;
public System.Collections.Generic.List<global::FrooxEngine.DynamicVisemeDriver.TargetDriver> Drivers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("MouthTrackingSource", MouthTrackingSource.ToResoniteReference(context));
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight.ToResoniteLinkField());
members.Add("Drivers", new ResoniteLink.SyncList()
{
    Elements = Drivers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
