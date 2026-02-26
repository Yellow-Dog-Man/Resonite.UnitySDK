
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstantLerpValue<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConstantLerpValue<>")]
public partial class ConstantLerpValue<T> : global::FrooxEngine.Component
	

{
    public T TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> TargetValue_Element = new();
public global::System.Single Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Speed_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();
public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue_Element.ToLinkField(context));
members.Add("Speed", Speed_Element.ToLinkField(context));
members.Add("WriteBack", WriteBack_Element.ToLinkField(context));
members.Add("Value", Value_Element.ToLinkReference(context));
}

}
}
