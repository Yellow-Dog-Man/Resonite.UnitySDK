
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+FundingStats
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics+FundingStats")]
public partial class FundingStats : global::FrooxEngine.SyncObject

{
    public global::System.Decimal TotalAmountUSD;
public global::System.Decimal AverageAmountUSD;
public global::System.Int32 TotalUniqueSupporters;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TotalAmountUSD", TotalAmountUSD.ToResoniteLinkField());
members.Add("AverageAmountUSD", AverageAmountUSD.ToResoniteLinkField());
members.Add("TotalUniqueSupporters", TotalUniqueSupporters.ToResoniteLinkField());
}

}
            }
}
