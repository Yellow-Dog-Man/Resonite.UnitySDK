
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Sender
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Sender")]
public partial class OSC_Sender : global::FrooxEngine.OSC_Handler

{
    public System.Uri URL;
public global::System.Int32 LocalPort;
public global::System.Boolean IsSending;
public global::FrooxEngine.OSC_SendMode SendMode;
public global::System.Single AutoResendInterval;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("LocalPort", LocalPort.ToResoniteLinkField());
members.Add("IsSending", IsSending.ToResoniteLinkField());
members.Add("SendMode", SendMode.ToResoniteLinkField());
members.Add("AutoResendInterval", AutoResendInterval.ToResoniteLinkField());
}

}
}
