
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxVertexValueSpatialVariable<>
// Generated on: sobota 14. února 2026 8:57:05
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public T Value0;
public T Value1;
public T Value2;
public T Value3;
public T Value4;
public T Value5;
public T Value6;
public T Value7;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value0", Value0.ToResoniteLinkField());
members.Add("Value1", Value1.ToResoniteLinkField());
members.Add("Value2", Value2.ToResoniteLinkField());
members.Add("Value3", Value3.ToResoniteLinkField());
members.Add("Value4", Value4.ToResoniteLinkField());
members.Add("Value5", Value5.ToResoniteLinkField());
members.Add("Value6", Value6.ToResoniteLinkField());
members.Add("Value7", Value7.ToResoniteLinkField());
}

}
}
