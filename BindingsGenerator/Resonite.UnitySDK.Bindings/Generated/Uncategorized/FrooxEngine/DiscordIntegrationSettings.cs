
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiscordIntegrationSettings
// Generated on: středa 25. února 2026 16:14:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DiscordIntegrationSettings")]
public partial class DiscordIntegrationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DiscordIntegrationSettings>

{
    public global::FrooxEngine.RichPresenceLevel RichPresence;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RichPresence", RichPresence.ToResoniteLinkField());
}

}
}
