
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamSettings")]
public partial class AudioStreamSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioStreamSettings>

{
    public global::System.Single DefaultBitrate;
public global::System.String DefaultDeviceID;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultBitrate", DefaultBitrate.ToResoniteLinkField());
members.Add("DefaultDeviceID", DefaultDeviceID.ToResoniteLinkField());
}

}
}
