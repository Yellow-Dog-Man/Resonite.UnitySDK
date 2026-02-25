
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionSettings
// Generated on: středa 25. února 2026 16:14:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionSettings")]
public partial class LocomotionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocomotionSettings>

{
    public System.Collections.Generic.List<global::FrooxEngine.PriorityEntry<global::FrooxEngine.LocomotionArchetype>> LocomotionPreferences;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocomotionPreferences", new ResoniteLink.SyncList()
{
    Elements = LocomotionPreferences.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
