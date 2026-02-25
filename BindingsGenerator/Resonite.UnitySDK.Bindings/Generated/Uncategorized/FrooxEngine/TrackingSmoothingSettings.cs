
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackingSmoothingSettings
// Generated on: středa 25. února 2026 16:14:43
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
    public global::System.Nullable<global::System.Single> HandPositionSmoothing;
public global::System.Nullable<global::System.Single> HandRotationSmoothing;
public global::System.Nullable<global::System.Single> FeetPositionSmoothing;
public global::System.Nullable<global::System.Single> FeetRotationSmoothing;
public global::System.Nullable<global::System.Single> HipsPositionSmoothing;
public global::System.Nullable<global::System.Single> HipsRotationSmoothing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HandPositionSmoothing", HandPositionSmoothing.ToResoniteLinkField());
members.Add("HandRotationSmoothing", HandRotationSmoothing.ToResoniteLinkField());
members.Add("FeetPositionSmoothing", FeetPositionSmoothing.ToResoniteLinkField());
members.Add("FeetRotationSmoothing", FeetRotationSmoothing.ToResoniteLinkField());
members.Add("HipsPositionSmoothing", HipsPositionSmoothing.ToResoniteLinkField());
members.Add("HipsRotationSmoothing", HipsRotationSmoothing.ToResoniteLinkField());
}

}
}
