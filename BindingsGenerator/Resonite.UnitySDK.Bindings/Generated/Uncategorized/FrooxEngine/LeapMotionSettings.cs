
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LeapMotionSettings
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LeapMotionSettings")]
public partial class LeapMotionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LeapMotionSettings>

{
    public global::System.Boolean LeapMotionEnabled { get => LeapMotionEnabled_Element.Data; set => LeapMotionEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LeapMotionEnabled_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::System.Single SnapDistance { get => SnapDistance_Element.Data; set => SnapDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapDistance_Element = new();
public global::System.Boolean UseFingersWhenSnapped { get => UseFingersWhenSnapped_Element.Data; set => UseFingersWhenSnapped_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFingersWhenSnapped_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeapMotionEnabled", LeapMotionEnabled_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("SnapDistance", SnapDistance_Element.ToLinkField(context));
members.Add("UseFingersWhenSnapped", UseFingersWhenSnapped_Element.ToLinkField(context));
}

}
}
