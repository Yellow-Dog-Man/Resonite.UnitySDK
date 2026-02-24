
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraRenderSettings
// Generated on: úterý 24. února 2026 18:20:23
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraRenderSettings")]
public partial class InteractiveCameraRenderSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraRenderSettings>

{
    public global::System.Boolean HideAllBadges;
public global::System.Boolean HideAllLasers;
public global::System.Boolean ForceEyesOnCamera;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HideAllBadges", HideAllBadges.ToResoniteLinkField());
members.Add("HideAllLasers", HideAllLasers.ToResoniteLinkField());
members.Add("ForceEyesOnCamera", ForceEyesOnCamera.ToResoniteLinkField());
}

}
}
