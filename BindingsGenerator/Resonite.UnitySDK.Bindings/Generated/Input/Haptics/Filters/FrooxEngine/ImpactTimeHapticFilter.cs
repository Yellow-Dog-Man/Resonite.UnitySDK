
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImpactTimeHapticFilter
// Generated on: čtvrtek 26. února 2026 12:26:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImpactTimeHapticFilter")]
public partial class ImpactTimeHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Boolean UseGlobalTime { get => UseGlobalTime_Element.Data; set => UseGlobalTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseGlobalTime_Element = new();
public global::System.Single StartTime { get => StartTime_Element.Data; set => StartTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartTime_Element = new();
public global::System.Single EndTime { get => EndTime_Element.Data; set => EndTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndTime_Element = new();
public global::System.Single StartIntensity { get => StartIntensity_Element.Data; set => StartIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartIntensity_Element = new();
public global::System.Single EndIntensity { get => EndIntensity_Element.Data; set => EndIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndIntensity_Element = new();
public global::System.Single Power { get => Power_Element.Data; set => Power_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Power_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseGlobalTime", UseGlobalTime_Element.ToLinkField(context));
members.Add("StartTime", StartTime_Element.ToLinkField(context));
members.Add("EndTime", EndTime_Element.ToLinkField(context));
members.Add("StartIntensity", StartIntensity_Element.ToLinkField(context));
members.Add("EndIntensity", EndIntensity_Element.ToLinkField(context));
members.Add("Power", Power_Element.ToLinkField(context));
}

}
}
