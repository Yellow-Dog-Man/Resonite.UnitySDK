
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Light
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Light")]
public partial class Light : global::FrooxEngine.ChangeHandlingRenderableComponent, global::FrooxEngine.IRenderable

{
    public global::Renderite.Shared.LightType LightType;
public global::System.Single Intensity;
public UnityEngine.ColorX Color;
public global::Renderite.Shared.ShadowType ShadowType;
public global::System.Single ShadowStrength;
public global::System.Single ShadowNearPlane;
public global::System.Int32 ShadowMapResolution;
public global::System.Single ShadowBias;
public global::System.Single ShadowNormalBias;
public global::System.Single Range;
public global::System.Single SpotAngle;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Cookie;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightType", LightType.ToResoniteLinkField());
members.Add("Intensity", Intensity.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("ShadowType", ShadowType.ToResoniteLinkField());
members.Add("ShadowStrength", ShadowStrength.ToResoniteLinkField());
members.Add("ShadowNearPlane", ShadowNearPlane.ToResoniteLinkField());
members.Add("ShadowMapResolution", ShadowMapResolution.ToResoniteLinkField());
members.Add("ShadowBias", ShadowBias.ToResoniteLinkField());
members.Add("ShadowNormalBias", ShadowNormalBias.ToResoniteLinkField());
members.Add("Range", Range.ToResoniteLinkField());
members.Add("SpotAngle", SpotAngle.ToResoniteLinkField());
members.Add("Cookie", Cookie.ToResoniteReference(context));
}

}
}
