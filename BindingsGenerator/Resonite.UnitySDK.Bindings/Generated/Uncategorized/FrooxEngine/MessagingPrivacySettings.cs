
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MessagingPrivacySettings
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MessagingPrivacySettings")]
public partial class MessagingPrivacySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MessagingPrivacySettings>

{
    public global::System.Boolean DoNotSendReadStatus { get => DoNotSendReadStatus_Element.Data; set => DoNotSendReadStatus_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoNotSendReadStatus_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DoNotSendReadStatus", DoNotSendReadStatus_Element.ToLinkField(context));
}

}
}
