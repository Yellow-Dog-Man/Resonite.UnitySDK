
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HostAccessSettings
// Generated on: pondělí 2. března 2026 17:53:34
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HostAccessSettings")]
public partial class HostAccessSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.HostAccessSettings>

{
    public global::SyncDictionary<global::FrooxEngine.SyncDictionary<global::System.String,global::FrooxEngine.HostAccessSettings.Entry>, global::System.String, global::FrooxEngine.HostAccessSettings.Entry> Entries = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Entries", Entries.ToLinkDictionary(context, m => m.ToLinkSyncObject(context)));
}

}
}
