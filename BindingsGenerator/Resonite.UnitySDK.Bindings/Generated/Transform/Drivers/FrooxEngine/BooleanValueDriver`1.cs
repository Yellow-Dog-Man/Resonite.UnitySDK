
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanValueDriver<>
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Boolean State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> State_Element = new();
public global::FrooxEngine.IField<T> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> TargetField_Element = new();
public T FalseValue { get => FalseValue_Element.Data; set => FalseValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> FalseValue_Element = new();
public T TrueValue { get => TrueValue_Element.Data; set => TrueValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> TrueValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State_Element.ToLinkField(context));
members.Add("TargetField", TargetField_Element.ToLinkReference(context));
members.Add("FalseValue", FalseValue_Element.ToLinkField(context));
members.Add("TrueValue", TrueValue_Element.ToLinkField(context));
}

}
}
