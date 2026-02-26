
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Tween<>
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Tween<>")]
public partial class Tween<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Target_Element = new();
public global::FrooxEngine.Slot OnlyUnderParent { get => OnlyUnderParent_Element.Data; set => OnlyUnderParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OnlyUnderParent_Element = new();
public T From { get => From_Element.Data; set => From_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> From_Element = new();
public T To { get => To_Element.Data; set => To_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> To_Element = new();
public global::System.Double StartTime { get => StartTime_Element.Data; set => StartTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> StartTime_Element = new();
public global::System.Single Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Duration_Element = new();
public global::FrooxEngine.CurvePreset Curve { get => Curve_Element.Data; set => Curve_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CurvePreset>, global::FrooxEngine.CurvePreset> Curve_Element = new();
public global::System.Boolean LocalCallback { get => LocalCallback_Element.Data; set => LocalCallback_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LocalCallback_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.Data.ToResoniteReference(context));
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("OnlyUnderParent", OnlyUnderParent_Element.Data.ToResoniteReference(context));
members.Add("From", From_Element.Data.ToResoniteLinkField());
members.Add("To", To_Element.Data.ToResoniteLinkField());
members.Add("StartTime", StartTime_Element.Data.ToResoniteLinkField());
members.Add("Duration", Duration_Element.Data.ToResoniteLinkField());
members.Add("Curve", Curve_Element.Data.ToResoniteLinkField());
members.Add("LocalCallback", LocalCallback_Element.Data.ToResoniteLinkField());
}

}
}
