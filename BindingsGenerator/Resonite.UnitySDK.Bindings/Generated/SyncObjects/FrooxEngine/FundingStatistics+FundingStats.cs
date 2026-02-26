
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+FundingStats
// Generated on: čtvrtek 26. února 2026 15:07:57
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
    public partial class FundingStatistics
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics+FundingStats")]
public partial class FundingStats : global::FrooxEngine.SyncObject

{
    public global::System.Decimal TotalAmountUSD { get => TotalAmountUSD_Element.Data; set => TotalAmountUSD_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Decimal>, global::System.Decimal> TotalAmountUSD_Element = new();
public global::System.Decimal AverageAmountUSD { get => AverageAmountUSD_Element.Data; set => AverageAmountUSD_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Decimal>, global::System.Decimal> AverageAmountUSD_Element = new();
public global::System.Int32 TotalUniqueSupporters { get => TotalUniqueSupporters_Element.Data; set => TotalUniqueSupporters_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalUniqueSupporters_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TotalAmountUSD", TotalAmountUSD_Element.ToLinkField(context));
members.Add("AverageAmountUSD", AverageAmountUSD_Element.ToLinkField(context));
members.Add("TotalUniqueSupporters", TotalUniqueSupporters_Element.ToLinkField(context));
}

}
            }
}
