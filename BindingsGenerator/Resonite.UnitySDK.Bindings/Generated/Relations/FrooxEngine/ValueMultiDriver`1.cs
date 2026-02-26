
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiDriver<>
// Generated on: čtvrtek 26. února 2026 10:04:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueMultiDriver<>")]
public partial class ValueMultiDriver<T> : global::FrooxEngine.Component
	

{
    public T Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<T>>, global::FrooxEngine.IField<T>, Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>>> Drives = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.Data.ToResoniteLinkField());
members.Add("Drives", new ResoniteLink.SyncList()
{
    Elements = Drives.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
