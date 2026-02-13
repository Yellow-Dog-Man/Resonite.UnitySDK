
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueEqualityDriver<>
// Generated on: pátek 13. února 2026 5:52:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueEqualityDriver<>")]
public partial class ValueEqualityDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> TargetValue;
public T Reference;
public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::System.Boolean Invert;
public global::System.Boolean UseApproximateComparison;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetValue", new ResoniteLink.Reference() { });
members.Add("Reference", Reference.ToResoniteLinkField());
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Invert", Invert.ToResoniteLinkField());
members.Add("UseApproximateComparison", UseApproximateComparison.ToResoniteLinkField());
}

}
}
