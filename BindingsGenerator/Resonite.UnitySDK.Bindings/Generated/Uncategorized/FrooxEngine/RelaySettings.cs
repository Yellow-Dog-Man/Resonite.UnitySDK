
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelaySettings
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RelaySettings")]
public partial class RelaySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RelaySettings>

{
    public global::System.Boolean AlwaysUseRelay { get => AlwaysUseRelay_Element.Data; set => AlwaysUseRelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysUseRelay_Element = new();
public global::System.Boolean UseClosestAvailableRelay { get => UseClosestAvailableRelay_Element.Data; set => UseClosestAvailableRelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseClosestAvailableRelay_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RelayPriorityEntry>, global::FrooxEngine.RelayPriorityEntry> RelayPriorities = new();
public global::System.Boolean RelayPrioritiesEnabled { get => RelayPrioritiesEnabled_Element.Data; set => RelayPrioritiesEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RelayPrioritiesEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AlwaysUseRelay", AlwaysUseRelay_Element.ToLinkField(context));
members.Add("UseClosestAvailableRelay", UseClosestAvailableRelay_Element.ToLinkField(context));
members.Add("RelayPriorities", RelayPriorities.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("RelayPrioritiesEnabled", RelayPrioritiesEnabled_Element.ToLinkField(context));
}

}
}
