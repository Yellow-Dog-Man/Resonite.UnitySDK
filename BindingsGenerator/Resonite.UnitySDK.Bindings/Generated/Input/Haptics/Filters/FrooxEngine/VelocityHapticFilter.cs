
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VelocityHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VelocityHapticFilter")]
public partial class VelocityHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Single VelocitySmoothTime { get => VelocitySmoothTime_Element.Data; set => VelocitySmoothTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocitySmoothTime_Element = new();
public global::System.Single StartVelocity { get => StartVelocity_Element.Data; set => StartVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartVelocity_Element = new();
public global::System.Single EndVelocity { get => EndVelocity_Element.Data; set => EndVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndVelocity_Element = new();
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
members.Add("VelocitySmoothTime", VelocitySmoothTime_Element.ToLinkField(context));
members.Add("StartVelocity", StartVelocity_Element.ToLinkField(context));
members.Add("EndVelocity", EndVelocity_Element.ToLinkField(context));
members.Add("StartIntensity", StartIntensity_Element.ToLinkField(context));
members.Add("EndIntensity", EndIntensity_Element.ToLinkField(context));
members.Add("Power", Power_Element.ToLinkField(context));
}

}
}
