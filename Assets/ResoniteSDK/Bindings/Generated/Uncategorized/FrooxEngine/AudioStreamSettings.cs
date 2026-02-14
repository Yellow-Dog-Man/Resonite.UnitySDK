
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSettings
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
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
