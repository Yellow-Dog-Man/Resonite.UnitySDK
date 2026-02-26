
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Light
// Generated on: čtvrtek 26. února 2026 15:07:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Light")]
public partial class Light : global::FrooxEngine.ChangeHandlingRenderableComponent, global::FrooxEngine.IRenderable

{
    public global::Renderite.Shared.LightType LightType { get => LightType_Element.Data; set => LightType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.LightType>, global::Renderite.Shared.LightType> LightType_Element = new();
public global::System.Single Intensity { get => Intensity_Element.Data; set => Intensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Intensity_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::Renderite.Shared.ShadowType ShadowType { get => ShadowType_Element.Data; set => ShadowType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowType>, global::Renderite.Shared.ShadowType> ShadowType_Element = new();
public global::System.Single ShadowStrength { get => ShadowStrength_Element.Data; set => ShadowStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowStrength_Element = new();
public global::System.Single ShadowNearPlane { get => ShadowNearPlane_Element.Data; set => ShadowNearPlane_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowNearPlane_Element = new();
public global::System.Int32 ShadowMapResolution { get => ShadowMapResolution_Element.Data; set => ShadowMapResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ShadowMapResolution_Element = new();
public global::System.Single ShadowBias { get => ShadowBias_Element.Data; set => ShadowBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowBias_Element = new();
public global::System.Single ShadowNormalBias { get => ShadowNormalBias_Element.Data; set => ShadowNormalBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowNormalBias_Element = new();
public global::System.Single Range { get => Range_Element.Data; set => Range_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Range_Element = new();
public global::System.Single SpotAngle { get => SpotAngle_Element.Data; set => SpotAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpotAngle_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Cookie { get => Cookie_Element.Data; set => Cookie_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>> Cookie_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightType", LightType_Element.ToLinkField(context));
members.Add("Intensity", Intensity_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("ShadowType", ShadowType_Element.ToLinkField(context));
members.Add("ShadowStrength", ShadowStrength_Element.ToLinkField(context));
members.Add("ShadowNearPlane", ShadowNearPlane_Element.ToLinkField(context));
members.Add("ShadowMapResolution", ShadowMapResolution_Element.ToLinkField(context));
members.Add("ShadowBias", ShadowBias_Element.ToLinkField(context));
members.Add("ShadowNormalBias", ShadowNormalBias_Element.ToLinkField(context));
members.Add("Range", Range_Element.ToLinkField(context));
members.Add("SpotAngle", SpotAngle_Element.ToLinkField(context));
members.Add("Cookie", Cookie_Element.ToLinkReference(context));
}

}
}
