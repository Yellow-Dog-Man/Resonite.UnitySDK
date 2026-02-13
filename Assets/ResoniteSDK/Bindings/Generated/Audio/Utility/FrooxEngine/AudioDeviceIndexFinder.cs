
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioDeviceIndexFinder
// Generated on: pátek 13. února 2026 5:51:10
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioDeviceIndexFinder")]
public partial class AudioDeviceIndexFinder : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex;
public global::System.String DeviceName;
public global::System.Boolean CaseSensitive;
public global::System.Boolean AllowPartialMatch;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DeviceIndex", DeviceIndex.ToResoniteLinkField());
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
members.Add("CaseSensitive", CaseSensitive.ToResoniteLinkField());
members.Add("AllowPartialMatch", AllowPartialMatch.ToResoniteLinkField());
}

}
}
