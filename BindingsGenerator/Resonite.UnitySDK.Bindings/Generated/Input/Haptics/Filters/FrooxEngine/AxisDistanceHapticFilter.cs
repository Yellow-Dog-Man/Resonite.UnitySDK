
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisDistanceHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisDistanceHapticFilter")]
public partial class AxisDistanceHapticFilter : global::FrooxEngine.HapticFilter

{
    public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public global::System.Single StartDistance { get => StartDistance_Element.Data; set => StartDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartDistance_Element = new();
public global::System.Single EndDistance { get => EndDistance_Element.Data; set => EndDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndDistance_Element = new();
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
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("StartDistance", StartDistance_Element.ToLinkField(context));
members.Add("EndDistance", EndDistance_Element.ToLinkField(context));
members.Add("StartIntensity", StartIntensity_Element.ToLinkField(context));
members.Add("EndIntensity", EndIntensity_Element.ToLinkField(context));
members.Add("Power", Power_Element.ToLinkField(context));
}

}
}
