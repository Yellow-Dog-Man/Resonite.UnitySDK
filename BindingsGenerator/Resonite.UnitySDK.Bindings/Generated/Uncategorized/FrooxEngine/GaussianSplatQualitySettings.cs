
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatQualitySettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatQualitySettings")]
public partial class GaussianSplatQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GaussianSplatQualitySettings>

{
    public global::FrooxEngine.GaussianSplatQualityPreset QualityPreset { get => QualityPreset_Element.Data; set => QualityPreset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GaussianSplatQualityPreset>, global::FrooxEngine.GaussianSplatQualityPreset> QualityPreset_Element = new();
public global::FrooxEngine.GaussianSplatQualityPreset MinLocalQuality { get => MinLocalQuality_Element.Data; set => MinLocalQuality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GaussianSplatQualityPreset>, global::FrooxEngine.GaussianSplatQualityPreset> MinLocalQuality_Element = new();
public global::System.Boolean AdvancedQuality { get => AdvancedQuality_Element.Data; set => AdvancedQuality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AdvancedQuality_Element = new();
public global::Renderite.Shared.GaussianVectorFormat PositionFormat { get => PositionFormat_Element.Data; set => PositionFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.GaussianVectorFormat>, global::Renderite.Shared.GaussianVectorFormat> PositionFormat_Element = new();
public global::Renderite.Shared.GaussianVectorFormat ScaleFormat { get => ScaleFormat_Element.Data; set => ScaleFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.GaussianVectorFormat>, global::Renderite.Shared.GaussianVectorFormat> ScaleFormat_Element = new();
public global::Renderite.Shared.GaussianColorFormat ColorFormat { get => ColorFormat_Element.Data; set => ColorFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.GaussianColorFormat>, global::Renderite.Shared.GaussianColorFormat> ColorFormat_Element = new();
public global::Renderite.Shared.GaussianSHFormat SphericalHarmonicsFormat { get => SphericalHarmonicsFormat_Element.Data; set => SphericalHarmonicsFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.GaussianSHFormat>, global::Renderite.Shared.GaussianSHFormat> SphericalHarmonicsFormat_Element = new();
public global::System.Single SortMegaOperationsPerCamera { get => SortMegaOperationsPerCamera_Element.Data; set => SortMegaOperationsPerCamera_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SortMegaOperationsPerCamera_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("QualityPreset", QualityPreset_Element.ToLinkField(context));
members.Add("MinLocalQuality", MinLocalQuality_Element.ToLinkField(context));
members.Add("AdvancedQuality", AdvancedQuality_Element.ToLinkField(context));
members.Add("PositionFormat", PositionFormat_Element.ToLinkField(context));
members.Add("ScaleFormat", ScaleFormat_Element.ToLinkField(context));
members.Add("ColorFormat", ColorFormat_Element.ToLinkField(context));
members.Add("SphericalHarmonicsFormat", SphericalHarmonicsFormat_Element.ToLinkField(context));
members.Add("SortMegaOperationsPerCamera", SortMegaOperationsPerCamera_Element.ToLinkField(context));
}

}
}
