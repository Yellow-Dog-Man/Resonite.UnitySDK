
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSettings
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSettings")]
public partial class AudioOutputDeviceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioOutputDeviceSettings>

{
    public global::System.Boolean UseSystemDefault { get => UseSystemDefault_Element.Data; set => UseSystemDefault_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSystemDefault_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DevicePriorityEntry>, global::FrooxEngine.DevicePriorityEntry> DevicePriorities = new();
public global::System.Boolean DevicePrioritiesEnabled { get => DevicePrioritiesEnabled_Element.Data; set => DevicePrioritiesEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DevicePrioritiesEnabled_Element = new();
public global::System.Boolean SeparateStreamingCameraOutput { get => SeparateStreamingCameraOutput_Element.Data; set => SeparateStreamingCameraOutput_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SeparateStreamingCameraOutput_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DevicePriorityEntry>, global::FrooxEngine.DevicePriorityEntry> StreamingCameraPriorities = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseSystemDefault", UseSystemDefault_Element.Data.ToResoniteLinkField());
members.Add("DevicePriorities", new ResoniteLink.SyncList()
{
    Elements = DevicePriorities.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("DevicePrioritiesEnabled", DevicePrioritiesEnabled_Element.Data.ToResoniteLinkField());
members.Add("SeparateStreamingCameraOutput", SeparateStreamingCameraOutput_Element.Data.ToResoniteLinkField());
members.Add("StreamingCameraPriorities", new ResoniteLink.SyncList()
{
    Elements = StreamingCameraPriorities.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
