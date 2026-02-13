
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatQualitySettings
// Generated on: pátek 13. února 2026 5:52:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatQualitySettings")]
public partial class GaussianSplatQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GaussianSplatQualitySettings>

{
    public global::FrooxEngine.GaussianSplatQualityPreset QualityPreset;
public global::FrooxEngine.GaussianSplatQualityPreset MinLocalQuality;
public global::System.Boolean AdvancedQuality;
public global::Renderite.Shared.GaussianVectorFormat PositionFormat;
public global::Renderite.Shared.GaussianVectorFormat ScaleFormat;
public global::Renderite.Shared.GaussianColorFormat ColorFormat;
public global::Renderite.Shared.GaussianSHFormat SphericalHarmonicsFormat;
public global::System.Single SortMegaOperationsPerCamera;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("QualityPreset", QualityPreset.ToResoniteLinkField());
members.Add("MinLocalQuality", MinLocalQuality.ToResoniteLinkField());
members.Add("AdvancedQuality", AdvancedQuality.ToResoniteLinkField());
members.Add("PositionFormat", PositionFormat.ToResoniteLinkField());
members.Add("ScaleFormat", ScaleFormat.ToResoniteLinkField());
members.Add("ColorFormat", ColorFormat.ToResoniteLinkField());
members.Add("SphericalHarmonicsFormat", SphericalHarmonicsFormat.ToResoniteLinkField());
members.Add("SortMegaOperationsPerCamera", SortMegaOperationsPerCamera.ToResoniteLinkField());
}

}
}
