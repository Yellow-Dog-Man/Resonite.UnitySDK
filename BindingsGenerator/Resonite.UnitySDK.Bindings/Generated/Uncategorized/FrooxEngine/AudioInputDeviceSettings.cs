
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean UseSystemDefault { get => UseSystemDefault_Element.Data; set => UseSystemDefault_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSystemDefault_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DevicePriorityEntry>, global::FrooxEngine.DevicePriorityEntry> DevicePriorities = new();
public global::System.Boolean DevicePrioritiesEnabled { get => DevicePrioritiesEnabled_Element.Data; set => DevicePrioritiesEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DevicePrioritiesEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseSystemDefault", UseSystemDefault_Element.ToLinkField(context));
members.Add("DevicePriorities", DevicePriorities.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("DevicePrioritiesEnabled", DevicePrioritiesEnabled_Element.ToLinkField(context));
}

}
}
