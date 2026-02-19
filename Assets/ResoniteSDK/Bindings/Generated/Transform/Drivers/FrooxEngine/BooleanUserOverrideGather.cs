
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanUserOverrideGather
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanUserOverrideGather")]
public partial class BooleanUserOverrideGather : global::FrooxEngine.ValueUserOverride<global::System.Boolean>

{
    public global::System.Boolean Any;
public global::System.Boolean All;
public global::System.Boolean None;
public global::System.Int32 TrueCount;
public global::System.Int32 FalseCount;
public global::System.Boolean ExcludeHeadless;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Any", Any.ToResoniteLinkField());
members.Add("All", All.ToResoniteLinkField());
members.Add("None", None.ToResoniteLinkField());
members.Add("TrueCount", TrueCount.ToResoniteLinkField());
members.Add("FalseCount", FalseCount.ToResoniteLinkField());
members.Add("ExcludeHeadless", ExcludeHeadless.ToResoniteLinkField());
}

}
}
