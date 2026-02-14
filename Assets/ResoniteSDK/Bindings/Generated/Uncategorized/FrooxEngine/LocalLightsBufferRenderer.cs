
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalLightsBufferRenderer
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalLightsBufferRenderer")]
public partial class LocalLightsBufferRenderer : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::Renderite.Shared.LightType LightType;
public global::Renderite.Shared.ShadowType ShadowType;
public global::System.Single ShadowStrength;
public global::System.Single ShadowNearPlane;
public global::System.Int32 ShadowMapResolution;
public global::System.Single ShadowBias;
public global::System.Single ShadowNormalBias;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Cookie;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightType", LightType.ToResoniteLinkField());
members.Add("ShadowType", ShadowType.ToResoniteLinkField());
members.Add("ShadowStrength", ShadowStrength.ToResoniteLinkField());
members.Add("ShadowNearPlane", ShadowNearPlane.ToResoniteLinkField());
members.Add("ShadowMapResolution", ShadowMapResolution.ToResoniteLinkField());
members.Add("ShadowBias", ShadowBias.ToResoniteLinkField());
members.Add("ShadowNormalBias", ShadowNormalBias.ToResoniteLinkField());
members.Add("Cookie", Cookie.ToResoniteReference(context));
}

}
}
