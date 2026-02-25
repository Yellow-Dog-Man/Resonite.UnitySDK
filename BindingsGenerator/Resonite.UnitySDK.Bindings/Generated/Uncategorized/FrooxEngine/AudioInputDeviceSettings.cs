
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSettings
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceSettings")]
public partial class AudioInputDeviceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioInputDeviceSettings>

{
    public global::System.Boolean UseSystemDefault;
public System.Collections.Generic.List<global::FrooxEngine.DevicePriorityEntry> DevicePriorities;
public global::System.Boolean DevicePrioritiesEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseSystemDefault", UseSystemDefault.ToResoniteLinkField());
members.Add("DevicePriorities", new ResoniteLink.SyncList()
{
    Elements = DevicePriorities.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("DevicePrioritiesEnabled", DevicePrioritiesEnabled.ToResoniteLinkField());
}

}
}
