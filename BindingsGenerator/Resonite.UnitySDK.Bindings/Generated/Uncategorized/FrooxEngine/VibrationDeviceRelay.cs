
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VibrationDeviceRelay
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VibrationDeviceRelay")]
public partial class VibrationDeviceRelay : global::FrooxEngine.Component, global::FrooxEngine.IVibrationDeviceComponent

{
    public global::FrooxEngine.IVibrationDeviceComponent TargetComponent { get => TargetComponent_Element.Data; set => TargetComponent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IVibrationDeviceComponent>, global::FrooxEngine.IVibrationDeviceComponent> TargetComponent_Element = new();
public global::FrooxEngine.Slot DynamicLookupTarget { get => DynamicLookupTarget_Element.Data; set => DynamicLookupTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DynamicLookupTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetComponent", TargetComponent_Element.Data.ToResoniteReference(context));
members.Add("DynamicLookupTarget", DynamicLookupTarget_Element.Data.ToResoniteReference(context));
}

}
}
