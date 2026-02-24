
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanValueDriver<>
// Generated on: úterý 24. února 2026 18:20:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanValueDriver<>")]
public partial class BooleanValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::System.Boolean State;
public global::FrooxEngine.IField<T> TargetField;
public T FalseValue;
public T TrueValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("FalseValue", FalseValue.ToResoniteLinkField());
members.Add("TrueValue", TrueValue.ToResoniteLinkField());
}

}
}
