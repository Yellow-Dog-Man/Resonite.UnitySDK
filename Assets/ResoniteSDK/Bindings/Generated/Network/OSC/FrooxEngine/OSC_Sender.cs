
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Sender
// Generated on: pátek 13. února 2026 23:21:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Sender")]
public partial class OSC_Sender : global::FrooxEngine.OSC_Handler

{
    public System.Uri URL;
public global::System.Int32 LocalPort;
public global::System.Boolean IsSending;
public global::FrooxEngine.OSC_SendMode SendMode;
public global::System.Single AutoResendInterval;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("LocalPort", LocalPort.ToResoniteLinkField());
members.Add("IsSending", IsSending.ToResoniteLinkField());
members.Add("SendMode", SendMode.ToResoniteLinkField());
members.Add("AutoResendInterval", AutoResendInterval.ToResoniteLinkField());
}

}
}
