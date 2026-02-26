
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackingSmoothingSettings
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackingSmoothingSettings")]
public partial class TrackingSmoothingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TrackingSmoothingSettings>

{
    public global::System.Nullable<global::System.Single> HandPositionSmoothing { get => HandPositionSmoothing_Element.Data; set => HandPositionSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HandPositionSmoothing_Element = new();
public global::System.Nullable<global::System.Single> HandRotationSmoothing { get => HandRotationSmoothing_Element.Data; set => HandRotationSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HandRotationSmoothing_Element = new();
public global::System.Nullable<global::System.Single> FeetPositionSmoothing { get => FeetPositionSmoothing_Element.Data; set => FeetPositionSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FeetPositionSmoothing_Element = new();
public global::System.Nullable<global::System.Single> FeetRotationSmoothing { get => FeetRotationSmoothing_Element.Data; set => FeetRotationSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FeetRotationSmoothing_Element = new();
public global::System.Nullable<global::System.Single> HipsPositionSmoothing { get => HipsPositionSmoothing_Element.Data; set => HipsPositionSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HipsPositionSmoothing_Element = new();
public global::System.Nullable<global::System.Single> HipsRotationSmoothing { get => HipsRotationSmoothing_Element.Data; set => HipsRotationSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HipsRotationSmoothing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HandPositionSmoothing", HandPositionSmoothing_Element.Data.ToResoniteLinkField());
members.Add("HandRotationSmoothing", HandRotationSmoothing_Element.Data.ToResoniteLinkField());
members.Add("FeetPositionSmoothing", FeetPositionSmoothing_Element.Data.ToResoniteLinkField());
members.Add("FeetRotationSmoothing", FeetRotationSmoothing_Element.Data.ToResoniteLinkField());
members.Add("HipsPositionSmoothing", HipsPositionSmoothing_Element.Data.ToResoniteLinkField());
members.Add("HipsRotationSmoothing", HipsRotationSmoothing_Element.Data.ToResoniteLinkField());
}

}
}
