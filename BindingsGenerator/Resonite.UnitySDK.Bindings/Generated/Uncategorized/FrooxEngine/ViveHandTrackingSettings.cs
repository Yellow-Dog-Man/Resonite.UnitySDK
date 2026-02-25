
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViveHandTrackingSettings
// Generated on: středa 25. února 2026 16:14:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ViveHandTrackingSettings")]
public partial class ViveHandTrackingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ViveHandTrackingSettings>

{
    public global::System.Boolean ViveHandTrackingEnabled;
public global::System.Single SnapDistance;
public global::System.Boolean UseFingersWhenSnapped;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViveHandTrackingEnabled", ViveHandTrackingEnabled.ToResoniteLinkField());
members.Add("SnapDistance", SnapDistance.ToResoniteLinkField());
members.Add("UseFingersWhenSnapped", UseFingersWhenSnapped.ToResoniteLinkField());
}

}
}
