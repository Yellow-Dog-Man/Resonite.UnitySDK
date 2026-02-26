
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralSkyMaterial
// Generated on: čtvrtek 26. února 2026 10:03:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralSkyMaterial")]
public partial class ProceduralSkyMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ISkyboxMaterial

{
    public global::FrooxEngine.ProceduralSkyMaterial.SunType SunQuality { get => SunQuality_Element.Data; set => SunQuality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ProceduralSkyMaterial.SunType>, global::FrooxEngine.ProceduralSkyMaterial.SunType> SunQuality_Element = new();
public global::System.Single SunSize { get => SunSize_Element.Data; set => SunSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SunSize_Element = new();
public global::FrooxEngine.Light Sun { get => Sun_Element.Data; set => Sun_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> Sun_Element = new();
public global::System.Single AtmosphereThickness { get => AtmosphereThickness_Element.Data; set => AtmosphereThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AtmosphereThickness_Element = new();
public UnityEngine.ColorX SkyTint { get => SkyTint_Element.Data; set => SkyTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SkyTint_Element = new();
public UnityEngine.ColorX GroundColor { get => GroundColor_Element.Data; set => GroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> GroundColor_Element = new();
public global::System.Single Exposure { get => Exposure_Element.Data; set => Exposure_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exposure_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SunQuality", SunQuality_Element.Data.ToResoniteLinkField());
members.Add("SunSize", SunSize_Element.Data.ToResoniteLinkField());
members.Add("Sun", Sun_Element.Data.ToResoniteReference(context));
members.Add("AtmosphereThickness", AtmosphereThickness_Element.Data.ToResoniteLinkField());
members.Add("SkyTint", SkyTint_Element.Data.ToResoniteLinkField());
members.Add("GroundColor", GroundColor_Element.Data.ToResoniteLinkField());
members.Add("Exposure", Exposure_Element.Data.ToResoniteLinkField());
}

}
}
