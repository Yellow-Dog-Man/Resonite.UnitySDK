
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VibrationDeviceRelay
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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
