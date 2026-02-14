
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueEqualityDriver<>
// Generated on: sobota 14. února 2026 8:58:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueEqualityDriver<>")]
public partial class ValueEqualityDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> TargetValue;
public T Reference;
public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::System.Boolean Invert;
public global::System.Boolean UseApproximateComparison;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
members.Add("Reference", Reference.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Invert", Invert.ToResoniteLinkField());
members.Add("UseApproximateComparison", UseApproximateComparison.ToResoniteLinkField());
}

}
}
