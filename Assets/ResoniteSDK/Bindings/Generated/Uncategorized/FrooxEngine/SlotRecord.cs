
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotRecord
// Generated on: sobota 14. února 2026 8:58:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotRecord")]
public partial class SlotRecord : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.Slot TargetSlot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
}

}
}
