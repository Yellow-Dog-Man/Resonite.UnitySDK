
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+FundingStats
// Generated on: čtvrtek 19. února 2026 7:58:55
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TotalAmountUSD", TotalAmountUSD.ToResoniteLinkField());
members.Add("AverageAmountUSD", AverageAmountUSD.ToResoniteLinkField());
members.Add("TotalUniqueSupporters", TotalUniqueSupporters.ToResoniteLinkField());
}

}
            }
}
