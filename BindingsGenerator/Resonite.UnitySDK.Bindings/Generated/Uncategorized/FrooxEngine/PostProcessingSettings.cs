
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PostProcessingSettings
// Generated on: čtvrtek 26. února 2026 12:28:12
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PostProcessingSettings")]
public partial class PostProcessingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.PostProcessingSettings>

{
    public global::System.Single MotionBlurIntensity { get => MotionBlurIntensity_Element.Data; set => MotionBlurIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MotionBlurIntensity_Element = new();
public global::System.Single BloomIntensity { get => BloomIntensity_Element.Data; set => BloomIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BloomIntensity_Element = new();
public global::System.Single AmbientOcclusionIntensity { get => AmbientOcclusionIntensity_Element.Data; set => AmbientOcclusionIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AmbientOcclusionIntensity_Element = new();
public global::System.Boolean ScreenSpaceReflections { get => ScreenSpaceReflections_Element.Data; set => ScreenSpaceReflections_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSpaceReflections_Element = new();
public global::Renderite.Shared.AntiAliasingMethod Antialiasing { get => Antialiasing_Element.Data; set => Antialiasing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.AntiAliasingMethod>, global::Renderite.Shared.AntiAliasingMethod> Antialiasing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MotionBlurIntensity", MotionBlurIntensity_Element.ToLinkField(context));
members.Add("BloomIntensity", BloomIntensity_Element.ToLinkField(context));
members.Add("AmbientOcclusionIntensity", AmbientOcclusionIntensity_Element.ToLinkField(context));
members.Add("ScreenSpaceReflections", ScreenSpaceReflections_Element.ToLinkField(context));
members.Add("Antialiasing", Antialiasing_Element.ToLinkField(context));
}

}
}
