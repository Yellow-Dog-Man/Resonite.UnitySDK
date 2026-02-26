
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WebsocketClient
// Generated on: čtvrtek 26. února 2026 10:03:40
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
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::FrooxEngine.UserRef HandlingUser = new();
public global::System.String AccessReason { get => AccessReason_Element.Data; set => AccessReason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AccessReason_Element = new();
public global::System.Single ConnectRetryInterval { get => ConnectRetryInterval_Element.Data; set => ConnectRetryInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ConnectRetryInterval_Element = new();
public global::System.Boolean IsConnected { get => IsConnected_Element.Data; set => IsConnected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsConnected_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.Data.ToResoniteLinkField());
members.Add("HandlingUser", new ResoniteLink.SyncObject() { Members = HandlingUser.CollectMembers(context) });
members.Add("AccessReason", AccessReason_Element.Data.ToResoniteLinkField());
members.Add("ConnectRetryInterval", ConnectRetryInterval_Element.Data.ToResoniteLinkField());
members.Add("IsConnected", IsConnected_Element.Data.ToResoniteLinkField());
}

}
}
