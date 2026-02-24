
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceInfo
// Generated on: úterý 24. února 2026 18:17:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceInfo")]
public partial class AudioInputDeviceInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex;
public global::System.String DeviceName;
public global::System.Boolean IsAppDefault;
public global::System.Boolean IsSystemDefault;
public global::FrooxEngine.AudioInputType DeviceType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
members.Add("IsAppDefault", IsAppDefault.ToResoniteLinkField());
members.Add("IsSystemDefault", IsSystemDefault.ToResoniteLinkField());
members.Add("DeviceType", DeviceType.ToResoniteLinkField());
}

}
}
