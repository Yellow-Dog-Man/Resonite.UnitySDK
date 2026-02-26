
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonValueShift<>
// Generated on: čtvrtek 26. února 2026 12:26:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonValueShift<>")]
public partial class ButtonValueShift<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	

{
    public global::FrooxEngine.IField<T> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetValue_Element = new();
public T Delta { get => Delta_Element.Data; set => Delta_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Delta_Element = new();
public T Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Min_Element = new();
public T Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Max_Element = new();
public global::System.Boolean WrapAround { get => WrapAround_Element.Data; set => WrapAround_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WrapAround_Element = new();
public global::System.Boolean MaxIsExclusive { get => MaxIsExclusive_Element.Data; set => MaxIsExclusive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MaxIsExclusive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("Delta", Delta_Element.ToLinkField(context));
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
members.Add("WrapAround", WrapAround_Element.ToLinkField(context));
members.Add("MaxIsExclusive", MaxIsExclusive_Element.ToLinkField(context));
}

}
}
