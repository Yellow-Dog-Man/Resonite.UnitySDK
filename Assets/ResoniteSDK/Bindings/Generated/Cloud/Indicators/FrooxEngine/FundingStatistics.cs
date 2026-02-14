
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics
// Generated on: sobota 14. února 2026 8:57:02
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timestamp", Timestamp.ToResoniteLinkField());
members.Add("Aggregate", new ResoniteLink.SyncObject() { Members = Aggregate.CollectMembers(context) });
members.Add("Patreon", new ResoniteLink.SyncObject() { Members = Patreon.CollectMembers(context) });
members.Add("Stripe", new ResoniteLink.SyncObject() { Members = Stripe.CollectMembers(context) });
}

}
}
