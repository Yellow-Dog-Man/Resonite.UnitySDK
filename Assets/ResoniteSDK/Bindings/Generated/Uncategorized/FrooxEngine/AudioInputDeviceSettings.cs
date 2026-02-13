
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSettings
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceSettings")]
public partial class AudioInputDeviceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioInputDeviceSettings>

{
    public global::System.Boolean UseSystemDefault;
public System.Collections.Generic.List<global::FrooxEngine.DevicePriorityEntry> DevicePriorities;
public global::System.Boolean DevicePrioritiesEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseSystemDefault", UseSystemDefault.ToResoniteLinkField());
members.Add("DevicePriorities", new ResoniteLink.SyncList()
{
    Elements = DevicePriorities.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("DevicePrioritiesEnabled", DevicePrioritiesEnabled.ToResoniteLinkField());
}

}
}
