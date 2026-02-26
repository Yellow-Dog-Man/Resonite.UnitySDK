
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonEnumShift<>
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonEnumShift<>")]
public partial class ButtonEnumShift<E> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where E : System.Enum

{
    public global::FrooxEngine.IField<E> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<E>>, global::FrooxEngine.IField<E>> TargetValue_Element = new();
public global::System.Int32 ShiftDelta { get => ShiftDelta_Element.Data; set => ShiftDelta_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ShiftDelta_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("ShiftDelta", ShiftDelta_Element.ToLinkField(context));
}

}
}
