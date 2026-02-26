
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DirectTagHapticSource
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DirectTagHapticSource")]
public partial class DirectTagHapticSource : global::FrooxEngine.Component, global::FrooxEngine.IDirectHapticSource

{
    public global::System.String HapticTag { get => HapticTag_Element.Data; set => HapticTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HapticTag_Element = new();
public global::System.Single Force { get => Force_Element.Data; set => Force_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Force_Element = new();
public global::System.Single Temperature { get => Temperature_Element.Data; set => Temperature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Temperature_Element = new();
public global::System.Single Pain { get => Pain_Element.Data; set => Pain_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Pain_Element = new();
public global::System.Single Vibration { get => Vibration_Element.Data; set => Vibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Vibration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticTag", HapticTag_Element.ToLinkField(context));
members.Add("Force", Force_Element.ToLinkField(context));
members.Add("Temperature", Temperature_Element.ToLinkField(context));
members.Add("Pain", Pain_Element.ToLinkField(context));
members.Add("Vibration", Vibration_Element.ToLinkField(context));
}

}
}
