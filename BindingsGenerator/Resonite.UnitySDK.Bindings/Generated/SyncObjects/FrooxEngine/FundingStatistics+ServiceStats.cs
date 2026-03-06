
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics+ServiceStats
// Generated on: pátek 6. března 2026 14:18:06
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
