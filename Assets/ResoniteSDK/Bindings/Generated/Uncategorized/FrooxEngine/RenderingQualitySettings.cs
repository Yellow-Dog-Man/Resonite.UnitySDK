
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderingQualitySettings
// Generated on: úterý 24. února 2026 18:20:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderingQualitySettings")]
public partial class RenderingQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RenderingQualitySettings>

{
    public global::System.Int32 PerPixelLights;
public global::Renderite.Shared.ShadowCascadeMode ShadowCascades;
public global::Renderite.Shared.ShadowResolutionMode ShadowResolution;
public global::System.Single ShadowDistance;
public global::Renderite.Shared.SkinWeightMode SkinWeightMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PerPixelLights", PerPixelLights.ToResoniteLinkField());
members.Add("ShadowCascades", ShadowCascades.ToResoniteLinkField());
members.Add("ShadowResolution", ShadowResolution.ToResoniteLinkField());
members.Add("ShadowDistance", ShadowDistance.ToResoniteLinkField());
members.Add("SkinWeightMode", SkinWeightMode.ToResoniteLinkField());
}

}
}
