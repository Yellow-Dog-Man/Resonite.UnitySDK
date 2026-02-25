
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LeapMotionSettings
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LeapMotionSettings")]
public partial class LeapMotionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LeapMotionSettings>

{
    public global::System.Boolean LeapMotionEnabled;
public UnityEngine.Vector3 Offset;
public global::System.Single SnapDistance;
public global::System.Boolean UseFingersWhenSnapped;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeapMotionEnabled", LeapMotionEnabled.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("SnapDistance", SnapDistance.ToResoniteLinkField());
members.Add("UseFingersWhenSnapped", UseFingersWhenSnapped.ToResoniteLinkField());
}

}
}
