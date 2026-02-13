
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceInfo
// Generated on: pátek 13. února 2026 23:21:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceInfo")]
public partial class AudioInputDeviceInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex;
public global::System.String DeviceName;
public global::System.Boolean IsAppDefault;
public global::System.Boolean IsSystemDefault;
public global::FrooxEngine.AudioInputType DeviceType;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
members.Add("IsAppDefault", IsAppDefault.ToResoniteLinkField());
members.Add("IsSystemDefault", IsSystemDefault.ToResoniteLinkField());
members.Add("DeviceType", DeviceType.ToResoniteLinkField());
}

}
}
