
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VibrationDeviceRelay
// Generated on: úterý 24. února 2026 18:20:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VibrationDeviceRelay")]
public partial class VibrationDeviceRelay : global::FrooxEngine.Component, global::FrooxEngine.IVibrationDeviceComponent

{
    public global::FrooxEngine.IVibrationDeviceComponent TargetComponent;
public global::FrooxEngine.Slot DynamicLookupTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetComponent", TargetComponent.ToResoniteReference(context));
members.Add("DynamicLookupTarget", DynamicLookupTarget.ToResoniteReference(context));
}

}
}
