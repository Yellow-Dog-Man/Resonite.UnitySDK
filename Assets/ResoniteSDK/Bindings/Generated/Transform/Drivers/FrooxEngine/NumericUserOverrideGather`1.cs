
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NumericUserOverrideGather<>
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
