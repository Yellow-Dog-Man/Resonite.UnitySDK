
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPostProcessingSettings
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPostProcessingSettings")]
public partial class InteractiveCameraPostProcessingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPostProcessingSettings>

{
    public global::System.Boolean MotionBlur;
public global::System.Boolean ScreenSpaceReflections;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MotionBlur", MotionBlur.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections.ToResoniteLinkField());
}

}
}
