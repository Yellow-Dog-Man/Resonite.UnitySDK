
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VibrationDeviceRelay
// Generated on: pátek 13. února 2026 5:52:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VibrationDeviceRelay")]
public partial class VibrationDeviceRelay : global::FrooxEngine.Component, global::FrooxEngine.IVibrationDeviceComponent

{
    public global::FrooxEngine.IVibrationDeviceComponent TargetComponent;
public global::FrooxEngine.Slot DynamicLookupTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetComponent", new ResoniteLink.Reference() { });
members.Add("DynamicLookupTarget", new ResoniteLink.Reference() { });
}

}
}
