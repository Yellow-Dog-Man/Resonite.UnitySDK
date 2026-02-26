
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats")]
public partial class ServiceStats : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FundingStatistics.FundingStats Current = new();
public global::FrooxEngine.FundingStatistics.FundingStats Historical = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Current", Current.ToLinkSyncObject(context));
members.Add("Historical", Historical.ToLinkSyncObject(context));
}

}
            }
}
