
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViveHandTrackingSettings
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ViveHandTrackingSettings")]
public partial class ViveHandTrackingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ViveHandTrackingSettings>

{
    public global::System.Boolean ViveHandTrackingEnabled;
public global::System.Single SnapDistance;
public global::System.Boolean UseFingersWhenSnapped;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ViveHandTrackingEnabled", ViveHandTrackingEnabled.ToResoniteLinkField());
members.Add("SnapDistance", SnapDistance.ToResoniteLinkField());
members.Add("UseFingersWhenSnapped", UseFingersWhenSnapped.ToResoniteLinkField());
}

}
}
