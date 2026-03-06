
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueMultiDriver<>
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<T>>, global::FrooxEngine.IField<T>, Reference<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>>> Drives = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkField(context));
members.Add("Drives", Drives.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
