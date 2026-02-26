
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FogBoxVolumeMaterial
// Generated on: čtvrtek 26. února 2026 10:03:35
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FogBoxVolumeMaterial")]
public partial class FogBoxVolumeMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public UnityEngine.ColorX AccumulationColor { get => AccumulationColor_Element.Data; set => AccumulationColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AccumulationColor_Element = new();
public UnityEngine.ColorX AccumulationColorBottom { get => AccumulationColorBottom_Element.Data; set => AccumulationColorBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AccumulationColorBottom_Element = new();
public UnityEngine.ColorX AccumulationColorTop { get => AccumulationColorTop_Element.Data; set => AccumulationColorTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AccumulationColorTop_Element = new();
public global::System.Single FogStart { get => FogStart_Element.Data; set => FogStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FogStart_Element = new();
public global::System.Single FogEnd { get => FogEnd_Element.Data; set => FogEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FogEnd_Element = new();
public global::System.Single FogDensity { get => FogDensity_Element.Data; set => FogDensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FogDensity_Element = new();
public global::System.Single GammaCurve { get => GammaCurve_Element.Data; set => GammaCurve_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GammaCurve_Element = new();
public global::System.Boolean WorldSpace { get => WorldSpace_Element.Data; set => WorldSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WorldSpace_Element = new();
public global::FrooxEngine.FogBoxVolumeMaterial.Color ColorMode { get => ColorMode_Element.Data; set => ColorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FogBoxVolumeMaterial.Color>, global::FrooxEngine.FogBoxVolumeMaterial.Color> ColorMode_Element = new();
public global::FrooxEngine.FogBoxVolumeMaterial.Saturation SaturationMode { get => SaturationMode_Element.Data; set => SaturationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FogBoxVolumeMaterial.Saturation>, global::FrooxEngine.FogBoxVolumeMaterial.Saturation> SaturationMode_Element = new();
public global::FrooxEngine.FogBoxVolumeMaterial.Accumulation AccumulationMode { get => AccumulationMode_Element.Data; set => AccumulationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FogBoxVolumeMaterial.Accumulation>, global::FrooxEngine.FogBoxVolumeMaterial.Accumulation> AccumulationMode_Element = new();
public global::System.Single AccumulationRate { get => AccumulationRate_Element.Data; set => AccumulationRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AccumulationRate_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor_Element.Data.ToResoniteLinkField());
members.Add("AccumulationColor", AccumulationColor_Element.Data.ToResoniteLinkField());
members.Add("AccumulationColorBottom", AccumulationColorBottom_Element.Data.ToResoniteLinkField());
members.Add("AccumulationColorTop", AccumulationColorTop_Element.Data.ToResoniteLinkField());
members.Add("FogStart", FogStart_Element.Data.ToResoniteLinkField());
members.Add("FogEnd", FogEnd_Element.Data.ToResoniteLinkField());
members.Add("FogDensity", FogDensity_Element.Data.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve_Element.Data.ToResoniteLinkField());
members.Add("WorldSpace", WorldSpace_Element.Data.ToResoniteLinkField());
members.Add("ColorMode", ColorMode_Element.Data.ToResoniteLinkField());
members.Add("SaturationMode", SaturationMode_Element.Data.ToResoniteLinkField());
members.Add("AccumulationMode", AccumulationMode_Element.Data.ToResoniteLinkField());
members.Add("AccumulationRate", AccumulationRate_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
