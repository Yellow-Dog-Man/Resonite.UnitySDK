
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HierarchyHapticsSource
// Generated on: čtvrtek 26. února 2026 10:03:39
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HierarchyHapticsSource")]
public partial class HierarchyHapticsSource : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot TargetHierarchy { get => TargetHierarchy_Element.Data; set => TargetHierarchy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetHierarchy_Element = new();
public global::System.Single Interval { get => Interval_Element.Data; set => Interval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Interval_Element = new();
public global::System.Single RelativeIntensity { get => RelativeIntensity_Element.Data; set => RelativeIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelativeIntensity_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetHierarchy", TargetHierarchy_Element.Data.ToResoniteReference(context));
members.Add("Interval", Interval_Element.Data.ToResoniteLinkField());
members.Add("RelativeIntensity", RelativeIntensity_Element.Data.ToResoniteLinkField());
}

}
}
