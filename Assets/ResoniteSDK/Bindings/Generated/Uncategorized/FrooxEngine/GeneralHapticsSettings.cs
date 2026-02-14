
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeneralHapticsSettings
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeneralHapticsSettings")]
public partial class GeneralHapticsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GeneralHapticsSettings>

{
    public global::System.Boolean EnableControllerVibration;
public global::System.Boolean EnableHaptics;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EnableControllerVibration", EnableControllerVibration.ToResoniteLinkField());
members.Add("EnableHaptics", EnableHaptics.ToResoniteLinkField());
}

}
}
