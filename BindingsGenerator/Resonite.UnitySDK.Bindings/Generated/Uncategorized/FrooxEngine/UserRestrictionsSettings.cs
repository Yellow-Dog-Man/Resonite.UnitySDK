
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRestrictionsSettings
// Generated on: pondělí 2. března 2026 17:53:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRestrictionsSettings")]
public partial class UserRestrictionsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.UserRestrictionsSettings>

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRestrictionsSettings.Entry>, global::FrooxEngine.UserRestrictionsSettings.Entry> Entries = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Entries", Entries.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
