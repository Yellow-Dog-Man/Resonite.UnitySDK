
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxVertexValueSpatialVariable<>
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxVertexValueSpatialVariable<>")]
public partial class BoxVertexValueSpatialVariable<T> : global::FrooxEngine.BoxSpatialVariable<T>
	

{
    public T Value0 { get => Value0_Element.Data; set => Value0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value0_Element = new();
public T Value1 { get => Value1_Element.Data; set => Value1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value1_Element = new();
public T Value2 { get => Value2_Element.Data; set => Value2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value2_Element = new();
public T Value3 { get => Value3_Element.Data; set => Value3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value3_Element = new();
public T Value4 { get => Value4_Element.Data; set => Value4_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value4_Element = new();
public T Value5 { get => Value5_Element.Data; set => Value5_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value5_Element = new();
public T Value6 { get => Value6_Element.Data; set => Value6_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value6_Element = new();
public T Value7 { get => Value7_Element.Data; set => Value7_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value7_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value0", Value0_Element.ToLinkField(context));
members.Add("Value1", Value1_Element.ToLinkField(context));
members.Add("Value2", Value2_Element.ToLinkField(context));
members.Add("Value3", Value3_Element.ToLinkField(context));
members.Add("Value4", Value4_Element.ToLinkField(context));
members.Add("Value5", Value5_Element.ToLinkField(context));
members.Add("Value6", Value6_Element.ToLinkField(context));
members.Add("Value7", Value7_Element.ToLinkField(context));
}

}
}
