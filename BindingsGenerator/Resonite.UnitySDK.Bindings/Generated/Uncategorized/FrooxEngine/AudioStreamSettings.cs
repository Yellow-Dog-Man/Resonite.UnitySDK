
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamSettings")]
public partial class AudioStreamSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioStreamSettings>

{
    public global::System.Single DefaultBitrate { get => DefaultBitrate_Element.Data; set => DefaultBitrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultBitrate_Element = new();
public global::System.String DefaultDeviceID { get => DefaultDeviceID_Element.Data; set => DefaultDeviceID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DefaultDeviceID_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultBitrate", DefaultBitrate_Element.Data.ToResoniteLinkField());
members.Add("DefaultDeviceID", DefaultDeviceID_Element.Data.ToResoniteLinkField());
}

}
}
