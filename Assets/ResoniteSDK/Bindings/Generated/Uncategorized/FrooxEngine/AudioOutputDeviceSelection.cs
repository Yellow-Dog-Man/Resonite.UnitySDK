
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSelection
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSelection")]
public partial class AudioOutputDeviceSelection : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedDeviceIndex;
public global::System.String SelectedDeviceName;
public global::FrooxEngine.Slot _deviceButtonRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex.ToResoniteLinkField());
members.Add("SelectedDeviceName", SelectedDeviceName.ToResoniteLinkField());
members.Add("_deviceButtonRoot", new ResoniteLink.Reference() { });
}

}
}
