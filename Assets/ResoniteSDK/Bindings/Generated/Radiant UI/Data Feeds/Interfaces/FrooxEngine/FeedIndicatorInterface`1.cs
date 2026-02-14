
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedIndicatorInterface<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedIndicatorInterface<>")]
public partial class FeedIndicatorInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.IField<T> Value;
public global::FrooxEngine.IField<global::System.String> Format;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("Format", Format.ToResoniteReference(context));
}

}
}
