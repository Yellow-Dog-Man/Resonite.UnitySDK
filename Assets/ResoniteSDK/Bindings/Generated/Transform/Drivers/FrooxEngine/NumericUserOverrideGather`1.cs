
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NumericUserOverrideGather<>
// Generated on: sobota 14. února 2026 8:58:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NumericUserOverrideGather<>")]
public partial class NumericUserOverrideGather<T> : global::FrooxEngine.ValueUserOverride<T>
	

{
    public T Min;
public T Max;
public T Sum;
public T Average;
public global::System.Boolean ExcludeHeadless;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("Sum", Sum.ToResoniteLinkField());
members.Add("Average", Average.ToResoniteLinkField());
members.Add("ExcludeHeadless", ExcludeHeadless.ToResoniteLinkField());
}

}
}
