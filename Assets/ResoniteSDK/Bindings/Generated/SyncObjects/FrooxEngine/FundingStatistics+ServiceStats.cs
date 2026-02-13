
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats
// Generated on: pátek 13. února 2026 23:21:37
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
    public partial class FundingStatistics
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats")]
public partial class ServiceStats : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FundingStatistics.FundingStats Current;
public global::FrooxEngine.FundingStatistics.FundingStats Historical;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Current", new ResoniteLink.SyncObject() { Members = Current.CollectMembers() });
members.Add("Historical", new ResoniteLink.SyncObject() { Members = Historical.CollectMembers() });
}

}
            }
}
