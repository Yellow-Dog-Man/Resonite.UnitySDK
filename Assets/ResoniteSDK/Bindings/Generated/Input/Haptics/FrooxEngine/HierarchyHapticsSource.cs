
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HierarchyHapticsSource
// Generated on: úterý 24. února 2026 18:17:49
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HierarchyHapticsSource")]
public partial class HierarchyHapticsSource : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot TargetHierarchy;
public global::System.Single Interval;
public global::System.Single RelativeIntensity;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetHierarchy", TargetHierarchy.ToResoniteReference(context));
members.Add("Interval", Interval.ToResoniteLinkField());
members.Add("RelativeIntensity", RelativeIntensity.ToResoniteLinkField());
}

}
}
