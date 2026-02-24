
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSettings
// Generated on: úterý 24. února 2026 18:20:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSettings")]
public partial class AudioOutputDeviceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioOutputDeviceSettings>

{
    public global::System.Boolean UseSystemDefault;
public System.Collections.Generic.List<global::FrooxEngine.DevicePriorityEntry> DevicePriorities;
public global::System.Boolean DevicePrioritiesEnabled;
public global::System.Boolean SeparateStreamingCameraOutput;
public System.Collections.Generic.List<global::FrooxEngine.DevicePriorityEntry> StreamingCameraPriorities;

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
members.Add("SeparateStreamingCameraOutput", SeparateStreamingCameraOutput.ToResoniteLinkField());
members.Add("StreamingCameraPriorities", new ResoniteLink.SyncList()
{
    Elements = StreamingCameraPriorities.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
