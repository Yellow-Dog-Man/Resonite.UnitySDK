
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudServerStatus
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudServerStatus")]
public partial class CloudServerStatus : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.ServerStatus Status;
public global::System.Int32 ResponseTimeMilliseconds;
public global::System.DateTime LastServerUpdateTime;
public global::System.DateTime LastServerStateFetch;
public global::System.DateTime LastLocalServerResponseTime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Status", Status.ToResoniteLinkField());
members.Add("ResponseTimeMilliseconds", ResponseTimeMilliseconds.ToResoniteLinkField());
members.Add("LastServerUpdateTime", LastServerUpdateTime.ToResoniteLinkField());
members.Add("LastServerStateFetch", LastServerStateFetch.ToResoniteLinkField());
members.Add("LastLocalServerResponseTime", LastLocalServerResponseTime.ToResoniteLinkField());
}

}
}
