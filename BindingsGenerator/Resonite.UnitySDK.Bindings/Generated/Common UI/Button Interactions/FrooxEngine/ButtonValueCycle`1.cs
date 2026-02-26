
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonValueCycle<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonValueCycle<>")]
public partial class ButtonValueCycle<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	

{
    public global::FrooxEngine.IField<T> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetValue_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<T>, T, Field<global::FrooxEngine.Sync<T>, T>> Values = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
members.Add("Values", Values.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
