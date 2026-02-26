
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointData
// Generated on: čtvrtek 26. února 2026 15:08:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointData")]
public partial class HapticPointData : global::FrooxEngine.Component

{
    public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::FrooxEngine.UserRef User = new();
public global::System.Single Force { get => Force_Element.Data; set => Force_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Force_Element = new();
public global::System.Single Temperature { get => Temperature_Element.Data; set => Temperature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Temperature_Element = new();
public global::System.Single Pain { get => Pain_Element.Data; set => Pain_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Pain_Element = new();
public global::System.Single Vibration { get => Vibration_Element.Data; set => Vibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Vibration_Element = new();
public global::System.Single TotalActivationIntensity { get => TotalActivationIntensity_Element.Data; set => TotalActivationIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TotalActivationIntensity_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Index", Index_Element.ToLinkField(context));
members.Add("User", User.ToLinkSyncObject(context));
members.Add("Force", Force_Element.ToLinkField(context));
members.Add("Temperature", Temperature_Element.ToLinkField(context));
members.Add("Pain", Pain_Element.ToLinkField(context));
members.Add("Vibration", Vibration_Element.ToLinkField(context));
members.Add("TotalActivationIntensity", TotalActivationIntensity_Element.ToLinkField(context));
}

}
}
