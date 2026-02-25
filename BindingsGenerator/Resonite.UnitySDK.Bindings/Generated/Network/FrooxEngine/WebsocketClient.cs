
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WebsocketClient
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WebsocketClient")]
public partial class WebsocketClient : global::FrooxEngine.Component

{
    public System.Uri URL;
public global::FrooxEngine.UserRef HandlingUser;
public global::System.String AccessReason;
public global::System.Single ConnectRetryInterval;
public global::System.Boolean IsConnected;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("HandlingUser", new ResoniteLink.SyncObject() { Members = HandlingUser.CollectMembers(context) });
members.Add("AccessReason", AccessReason.ToResoniteLinkField());
members.Add("ConnectRetryInterval", ConnectRetryInterval.ToResoniteLinkField());
members.Add("IsConnected", IsConnected.ToResoniteLinkField());
}

}
}
