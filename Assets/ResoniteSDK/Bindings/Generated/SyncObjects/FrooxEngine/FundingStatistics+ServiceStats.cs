
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats
// Generated on: úterý 24. února 2026 18:17:44
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Current", new ResoniteLink.SyncObject() { Members = Current.CollectMembers(context) });
members.Add("Historical", new ResoniteLink.SyncObject() { Members = Historical.CollectMembers(context) });
}

}
            }
}
