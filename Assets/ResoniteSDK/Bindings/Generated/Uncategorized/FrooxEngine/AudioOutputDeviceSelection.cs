
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSelection
// Generated on: úterý 24. února 2026 18:20:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSelection")]
public partial class AudioOutputDeviceSelection : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedDeviceIndex;
public global::System.String SelectedDeviceName;
public global::FrooxEngine.Slot _deviceButtonRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex.ToResoniteLinkField());
members.Add("SelectedDeviceName", SelectedDeviceName.ToResoniteLinkField());
members.Add("_deviceButtonRoot", _deviceButtonRoot.ToResoniteReference(context));
}

}
}
