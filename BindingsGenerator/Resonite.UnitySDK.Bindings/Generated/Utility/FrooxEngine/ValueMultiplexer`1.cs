
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiplexer<>
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueMultiplexer<>")]
public partial class ValueMultiplexer<T> : global::FrooxEngine.Component, global::FrooxEngine.IValue<T>, global::FrooxEngine.IValue
	

{
    public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Target_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<T>, T, Field<global::FrooxEngine.Sync<T>, T>> Values = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("Index", Index_Element.Data.ToResoniteLinkField());
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("AllowWriteBack", AllowWriteBack_Element.Data.ToResoniteLinkField());
}

}
}
