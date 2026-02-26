
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueEqualityDriver<>
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueEqualityDriver<>")]
public partial class ValueEqualityDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetValue_Element = new();
public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Reference_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Target_Element = new();
public global::System.Boolean Invert { get => Invert_Element.Data; set => Invert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Invert_Element = new();
public global::System.Boolean UseApproximateComparison { get => UseApproximateComparison_Element.Data; set => UseApproximateComparison_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseApproximateComparison_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("Reference", Reference_Element.ToLinkField(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Invert", Invert_Element.ToLinkField(context));
members.Add("UseApproximateComparison", UseApproximateComparison_Element.ToLinkField(context));
}

}
}
