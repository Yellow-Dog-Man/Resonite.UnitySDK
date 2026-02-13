
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver
// Generated on: pátek 13. února 2026 5:52:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver")]
public partial class DynamicVisemeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.VisemeAnalyzer Source;
public global::FrooxEngine.IMouthTrackingSourceComponent MouthTrackingSource;
public global::System.Single StrengthMultiplier;
public global::System.Single VoiceMouthSupressWeight;
public System.Collections.Generic.List<global::FrooxEngine.DynamicVisemeDriver.TargetDriver> Drivers;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("MouthTrackingSource", new ResoniteLink.Reference() { });
members.Add("StrengthMultiplier", StrengthMultiplier.ToResoniteLinkField());
members.Add("VoiceMouthSupressWeight", VoiceMouthSupressWeight.ToResoniteLinkField());
members.Add("Drivers", new ResoniteLink.SyncList()
{
    Elements = Drivers.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
