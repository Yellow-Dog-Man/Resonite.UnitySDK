
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderingQualitySettings
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderingQualitySettings")]
public partial class RenderingQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RenderingQualitySettings>

{
    public global::System.Int32 PerPixelLights;
public global::Renderite.Shared.ShadowCascadeMode ShadowCascades;
public global::Renderite.Shared.ShadowResolutionMode ShadowResolution;
public global::System.Single ShadowDistance;
public global::Renderite.Shared.SkinWeightMode SkinWeightMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PerPixelLights", PerPixelLights.ToResoniteLinkField());
members.Add("ShadowCascades", ShadowCascades.ToResoniteLinkField());
members.Add("ShadowResolution", ShadowResolution.ToResoniteLinkField());
members.Add("ShadowDistance", ShadowDistance.ToResoniteLinkField());
members.Add("SkinWeightMode", SkinWeightMode.ToResoniteLinkField());
}

}
}
