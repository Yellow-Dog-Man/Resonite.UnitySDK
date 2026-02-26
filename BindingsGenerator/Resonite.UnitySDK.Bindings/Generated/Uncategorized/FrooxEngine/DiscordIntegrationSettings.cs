
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiscordIntegrationSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DiscordIntegrationSettings")]
public partial class DiscordIntegrationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DiscordIntegrationSettings>

{
    public global::FrooxEngine.RichPresenceLevel RichPresence { get => RichPresence_Element.Data; set => RichPresence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.RichPresenceLevel>, global::FrooxEngine.RichPresenceLevel> RichPresence_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RichPresence", RichPresence_Element.ToLinkField(context));
}

}
}
