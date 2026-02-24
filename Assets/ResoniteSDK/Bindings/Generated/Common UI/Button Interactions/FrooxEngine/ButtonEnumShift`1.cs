
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonEnumShift<>
// Generated on: úterý 24. února 2026 18:17:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonEnumShift<>")]
public partial class ButtonEnumShift<E> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where E : System.Enum

{
    public global::FrooxEngine.IField<E> TargetValue;
public global::System.Int32 ShiftDelta;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
members.Add("ShiftDelta", ShiftDelta.ToResoniteLinkField());
}

}
}
