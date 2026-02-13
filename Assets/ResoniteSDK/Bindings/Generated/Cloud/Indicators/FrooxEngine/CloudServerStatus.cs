
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudServerStatus
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudServerStatus")]
public partial class CloudServerStatus : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.ServerStatus Status;
public global::System.Int32 ResponseTimeMilliseconds;
public global::System.DateTime LastServerUpdateTime;
public global::System.DateTime LastServerStateFetch;
public global::System.DateTime LastLocalServerResponseTime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Status", Status.ToResoniteLinkField());
members.Add("ResponseTimeMilliseconds", ResponseTimeMilliseconds.ToResoniteLinkField());
members.Add("LastServerUpdateTime", LastServerUpdateTime.ToResoniteLinkField());
members.Add("LastServerStateFetch", LastServerStateFetch.ToResoniteLinkField());
members.Add("LastLocalServerResponseTime", LastLocalServerResponseTime.ToResoniteLinkField());
}

}
}
