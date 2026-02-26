
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VibrationDeviceRelay
// Generated on: čtvrtek 26. února 2026 15:09:15
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VibrationDeviceRelay")]
public partial class VibrationDeviceRelay : global::FrooxEngine.Component, global::FrooxEngine.IVibrationDeviceComponent

{
    public global::FrooxEngine.IVibrationDeviceComponent TargetComponent { get => TargetComponent_Element.Data; set => TargetComponent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IVibrationDeviceComponent>, global::FrooxEngine.IVibrationDeviceComponent> TargetComponent_Element = new();
public global::FrooxEngine.Slot DynamicLookupTarget { get => DynamicLookupTarget_Element.Data; set => DynamicLookupTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DynamicLookupTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetComponent", TargetComponent_Element.ToLinkReference(context));
members.Add("DynamicLookupTarget", DynamicLookupTarget_Element.ToLinkReference(context));
}

}
}
