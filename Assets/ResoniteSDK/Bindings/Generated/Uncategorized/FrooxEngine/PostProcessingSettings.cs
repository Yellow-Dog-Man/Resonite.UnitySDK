
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PostProcessingSettings
// Generated on: sobota 14. února 2026 8:58:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PostProcessingSettings")]
public partial class PostProcessingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.PostProcessingSettings>

{
    public global::System.Single MotionBlurIntensity;
public global::System.Single BloomIntensity;
public global::System.Single AmbientOcclusionIntensity;
public global::System.Boolean ScreenSpaceReflections;
public global::Renderite.Shared.AntiAliasingMethod Antialiasing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MotionBlurIntensity", MotionBlurIntensity.ToResoniteLinkField());
members.Add("BloomIntensity", BloomIntensity.ToResoniteLinkField());
members.Add("AmbientOcclusionIntensity", AmbientOcclusionIntensity.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections.ToResoniteLinkField());
members.Add("Antialiasing", Antialiasing.ToResoniteLinkField());
}

}
}
