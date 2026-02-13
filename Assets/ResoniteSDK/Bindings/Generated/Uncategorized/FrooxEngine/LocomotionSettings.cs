
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionSettings
// Generated on: pátek 13. února 2026 5:52:34
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionSettings")]
public partial class LocomotionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocomotionSettings>

{
    public System.Collections.Generic.List<global::FrooxEngine.PriorityEntry<global::FrooxEngine.LocomotionArchetype>> LocomotionPreferences;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LocomotionPreferences", new ResoniteLink.SyncList()
{
    Elements = LocomotionPreferences.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
