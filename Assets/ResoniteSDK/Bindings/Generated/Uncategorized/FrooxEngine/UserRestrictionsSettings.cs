
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRestrictionsSettings
// Generated on: pátek 13. února 2026 23:23:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRestrictionsSettings")]
public partial class UserRestrictionsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.UserRestrictionsSettings>

{
    public System.Collections.Generic.List<global::FrooxEngine.UserRestrictionsSettings.Entry> Entries;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Entries", new ResoniteLink.SyncList()
{
    Elements = Entries.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
