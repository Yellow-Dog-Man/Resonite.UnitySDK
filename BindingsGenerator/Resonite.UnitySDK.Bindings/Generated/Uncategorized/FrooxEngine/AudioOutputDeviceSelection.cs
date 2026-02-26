
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSelection
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSelection")]
public partial class AudioOutputDeviceSelection : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedDeviceIndex { get => SelectedDeviceIndex_Element.Data; set => SelectedDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SelectedDeviceIndex_Element = new();
public global::System.String SelectedDeviceName { get => SelectedDeviceName_Element.Data; set => SelectedDeviceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SelectedDeviceName_Element = new();
public global::FrooxEngine.Slot _deviceButtonRoot { get => _deviceButtonRoot_Element.Data; set => _deviceButtonRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _deviceButtonRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedDeviceIndex", SelectedDeviceIndex_Element.Data.ToResoniteLinkField());
members.Add("SelectedDeviceName", SelectedDeviceName_Element.Data.ToResoniteLinkField());
members.Add("_deviceButtonRoot", _deviceButtonRoot_Element.Data.ToResoniteReference(context));
}

}
}
