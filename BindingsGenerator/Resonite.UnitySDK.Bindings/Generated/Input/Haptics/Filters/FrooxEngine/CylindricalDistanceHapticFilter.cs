
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CylindricalDistanceHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CylindricalDistanceHapticFilter")]
public partial class CylindricalDistanceHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Single StartRadius { get => StartRadius_Element.Data; set => StartRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartRadius_Element = new();
public global::System.Single EndRadius { get => EndRadius_Element.Data; set => EndRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndRadius_Element = new();
public global::System.Single StartRadiusIntensity { get => StartRadiusIntensity_Element.Data; set => StartRadiusIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartRadiusIntensity_Element = new();
public global::System.Single EndRadiusIntensity { get => EndRadiusIntensity_Element.Data; set => EndRadiusIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndRadiusIntensity_Element = new();
public global::System.Single RadiusPower { get => RadiusPower_Element.Data; set => RadiusPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusPower_Element = new();
public global::System.Single StartAxisOffset { get => StartAxisOffset_Element.Data; set => StartAxisOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartAxisOffset_Element = new();
public global::System.Single EndAxisOffset { get => EndAxisOffset_Element.Data; set => EndAxisOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndAxisOffset_Element = new();
public global::System.Single StartAxisIntensity { get => StartAxisIntensity_Element.Data; set => StartAxisIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartAxisIntensity_Element = new();
public global::System.Single EndAxisIntensity { get => EndAxisIntensity_Element.Data; set => EndAxisIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndAxisIntensity_Element = new();
public global::System.Single AxisPower { get => AxisPower_Element.Data; set => AxisPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AxisPower_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartRadius", StartRadius_Element.ToLinkField(context));
members.Add("EndRadius", EndRadius_Element.ToLinkField(context));
members.Add("StartRadiusIntensity", StartRadiusIntensity_Element.ToLinkField(context));
members.Add("EndRadiusIntensity", EndRadiusIntensity_Element.ToLinkField(context));
members.Add("RadiusPower", RadiusPower_Element.ToLinkField(context));
members.Add("StartAxisOffset", StartAxisOffset_Element.ToLinkField(context));
members.Add("EndAxisOffset", EndAxisOffset_Element.ToLinkField(context));
members.Add("StartAxisIntensity", StartAxisIntensity_Element.ToLinkField(context));
members.Add("EndAxisIntensity", EndAxisIntensity_Element.ToLinkField(context));
members.Add("AxisPower", AxisPower_Element.ToLinkField(context));
}

}
}
