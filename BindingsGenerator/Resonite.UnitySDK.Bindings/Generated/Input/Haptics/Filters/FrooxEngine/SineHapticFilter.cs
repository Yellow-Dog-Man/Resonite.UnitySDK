
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SineHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SineHapticFilter")]
public partial class SineHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Boolean UseGlobalTime { get => UseGlobalTime_Element.Data; set => UseGlobalTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseGlobalTime_Element = new();
public global::System.Nullable<global::System.Single> DistanceScale { get => DistanceScale_Element.Data; set => DistanceScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> DistanceScale_Element = new();
public global::System.Nullable<UnityEngine.Vector3> AxisScale { get => AxisScale_Element.Data; set => AxisScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> AxisScale_Element = new();
public global::System.Single MinIntensity { get => MinIntensity_Element.Data; set => MinIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinIntensity_Element = new();
public global::System.Single MaxIntensity { get => MaxIntensity_Element.Data; set => MaxIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxIntensity_Element = new();
public global::System.Single Frequency { get => Frequency_Element.Data; set => Frequency_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Frequency_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseGlobalTime", UseGlobalTime_Element.Data.ToResoniteLinkField());
members.Add("DistanceScale", DistanceScale_Element.Data.ToResoniteLinkField());
members.Add("AxisScale", AxisScale_Element.Data.ToResoniteLinkField());
members.Add("MinIntensity", MinIntensity_Element.Data.ToResoniteLinkField());
members.Add("MaxIntensity", MaxIntensity_Element.Data.ToResoniteLinkField());
members.Add("Frequency", Frequency_Element.Data.ToResoniteLinkField());
}

}
}
