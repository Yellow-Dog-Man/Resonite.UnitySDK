
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Sender
// Generated on: čtvrtek 26. února 2026 12:26:57
// Resonite version: 2026.2.26.702
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
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::System.Int32 LocalPort { get => LocalPort_Element.Data; set => LocalPort_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> LocalPort_Element = new();
public global::System.Boolean IsSending { get => IsSending_Element.Data; set => IsSending_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSending_Element = new();
public global::FrooxEngine.OSC_SendMode SendMode { get => SendMode_Element.Data; set => SendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.OSC_SendMode>, global::FrooxEngine.OSC_SendMode> SendMode_Element = new();
public global::System.Single AutoResendInterval { get => AutoResendInterval_Element.Data; set => AutoResendInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutoResendInterval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkField(context));
members.Add("LocalPort", LocalPort_Element.ToLinkField(context));
members.Add("IsSending", IsSending_Element.ToLinkField(context));
members.Add("SendMode", SendMode_Element.ToLinkField(context));
members.Add("AutoResendInterval", AutoResendInterval_Element.ToLinkField(context));
}

}
}
