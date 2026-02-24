
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelaySettings
// Generated on: úterý 24. února 2026 18:20:27
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RelaySettings")]
public partial class RelaySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RelaySettings>

{
    public global::System.Boolean AlwaysUseRelay;
public global::System.Boolean UseClosestAvailableRelay;
public System.Collections.Generic.List<global::FrooxEngine.RelayPriorityEntry> RelayPriorities;
public global::System.Boolean RelayPrioritiesEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AlwaysUseRelay", AlwaysUseRelay.ToResoniteLinkField());
members.Add("UseClosestAvailableRelay", UseClosestAvailableRelay.ToResoniteLinkField());
members.Add("RelayPriorities", new ResoniteLink.SyncList()
{
    Elements = RelayPriorities.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("RelayPrioritiesEnabled", RelayPrioritiesEnabled.ToResoniteLinkField());
}

}
}
