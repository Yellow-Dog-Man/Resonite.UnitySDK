
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanValueDriver<>
// Generated on: pátek 13. února 2026 5:52:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanValueDriver<>")]
public partial class BooleanValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::System.Boolean State;
public global::FrooxEngine.IField<T> TargetField;
public T FalseValue;
public T TrueValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetField", new ResoniteLink.Reference() { });
members.Add("FalseValue", FalseValue.ToResoniteLinkField());
members.Add("TrueValue", TrueValue.ToResoniteLinkField());
}

}
}
