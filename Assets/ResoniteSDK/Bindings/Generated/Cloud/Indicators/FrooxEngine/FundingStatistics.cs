
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics
// Generated on: pátek 13. února 2026 5:51:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics")]
public partial class FundingStatistics : global::FrooxEngine.Component

{
    public global::System.DateTime Timestamp;
public global::FrooxEngine.FundingStatistics.ServiceStats Aggregate;
public global::FrooxEngine.FundingStatistics.ServiceStats Patreon;
public global::FrooxEngine.FundingStatistics.ServiceStats Stripe;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Timestamp", Timestamp.ToResoniteLinkField());
members.Add("Aggregate", new ResoniteLink.SyncObject() { Members = Aggregate.CollectMembers() });
members.Add("Patreon", new ResoniteLink.SyncObject() { Members = Patreon.CollectMembers() });
members.Add("Stripe", new ResoniteLink.SyncObject() { Members = Stripe.CollectMembers() });
}

}
}
