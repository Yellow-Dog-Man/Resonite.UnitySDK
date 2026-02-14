
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EarmuffSettings
// Generated on: sobota 14. února 2026 8:58:42
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EarmuffSettings")]
public partial class EarmuffSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.EarmuffSettings>

{
    public global::System.Boolean EarmuffEnabled;
public global::System.Single VolumeAttenuation;
public global::System.Single Directionality;
public global::System.Single Distance;
public global::System.Single Angle;
public global::System.Single TransitionStart;
public global::System.Single TransitionLength;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EarmuffEnabled", EarmuffEnabled.ToResoniteLinkField());
members.Add("VolumeAttenuation", VolumeAttenuation.ToResoniteLinkField());
members.Add("Directionality", Directionality.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("Angle", Angle.ToResoniteLinkField());
members.Add("TransitionStart", TransitionStart.ToResoniteLinkField());
members.Add("TransitionLength", TransitionLength.ToResoniteLinkField());
}

}
}
