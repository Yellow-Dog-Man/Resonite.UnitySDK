
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PostProcessingSettings
// Generated on: pátek 13. února 2026 23:23:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PostProcessingSettings")]
public partial class PostProcessingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.PostProcessingSettings>

{
    public global::System.Single MotionBlurIntensity;
public global::System.Single BloomIntensity;
public global::System.Single AmbientOcclusionIntensity;
public global::System.Boolean ScreenSpaceReflections;
public global::Renderite.Shared.AntiAliasingMethod Antialiasing;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MotionBlurIntensity", MotionBlurIntensity.ToResoniteLinkField());
members.Add("BloomIntensity", BloomIntensity.ToResoniteLinkField());
members.Add("AmbientOcclusionIntensity", AmbientOcclusionIntensity.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections.ToResoniteLinkField());
members.Add("Antialiasing", Antialiasing.ToResoniteLinkField());
}

}
}
