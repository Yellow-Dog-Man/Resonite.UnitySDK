
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NumericUserOverrideGather<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NumericUserOverrideGather<>")]
public partial class NumericUserOverrideGather<T> : global::FrooxEngine.ValueUserOverride<T>
	

{
    public T Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<T>, T> Min_Element = new();
public T Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<T>, T> Max_Element = new();
public T Sum { get => Sum_Element.Data; set => Sum_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<T>, T> Sum_Element = new();
public T Average { get => Average_Element.Data; set => Average_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<T>, T> Average_Element = new();
public global::System.Boolean ExcludeHeadless { get => ExcludeHeadless_Element.Data; set => ExcludeHeadless_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeHeadless_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
members.Add("Sum", Sum_Element.ToLinkField(context));
members.Add("Average", Average_Element.ToLinkField(context));
members.Add("ExcludeHeadless", ExcludeHeadless_Element.ToLinkField(context));
}

}
}
