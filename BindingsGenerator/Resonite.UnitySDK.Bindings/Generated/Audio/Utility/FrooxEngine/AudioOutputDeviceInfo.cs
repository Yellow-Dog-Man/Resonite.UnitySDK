
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceInfo
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceInfo")]
public partial class AudioOutputDeviceInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex;
public global::System.String DeviceName;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
}

}
}
