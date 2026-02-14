
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>
// Generated on: sobota 14. února 2026 8:58:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>")]
public partial class FeedClampedValueFieldInterface<T> : global::FrooxEngine.FeedValueItemInterface<T>
	

{
    public global::FrooxEngine.IField<T> Min;
public global::FrooxEngine.IField<T> Max;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min.ToResoniteReference(context));
members.Add("Max", Max.ToResoniteReference(context));
}

}
}
