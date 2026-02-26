
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FundingStatistics
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FundingStatistics")]
public partial class FundingStatistics : global::FrooxEngine.Component

{
    public global::System.DateTime Timestamp { get => Timestamp_Element.Data; set => Timestamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> Timestamp_Element = new();
public global::FrooxEngine.FundingStatistics.ServiceStats Aggregate = new();
public global::FrooxEngine.FundingStatistics.ServiceStats Patreon = new();
public global::FrooxEngine.FundingStatistics.ServiceStats Stripe = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Timestamp", Timestamp_Element.ToLinkField(context));
members.Add("Aggregate", Aggregate.ToLinkSyncObject(context));
members.Add("Patreon", Patreon.ToLinkSyncObject(context));
members.Add("Stripe", Stripe.ToLinkSyncObject(context));
}

}
}
