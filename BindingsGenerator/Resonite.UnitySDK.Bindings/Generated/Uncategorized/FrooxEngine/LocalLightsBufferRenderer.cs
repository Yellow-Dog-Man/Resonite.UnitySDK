
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalLightsBufferRenderer
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalLightsBufferRenderer")]
public partial class LocalLightsBufferRenderer : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::Renderite.Shared.LightType LightType { get => LightType_Element.Data; set => LightType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.LightType>, global::Renderite.Shared.LightType> LightType_Element = new();
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
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Cookie { get => Cookie_Element.Data; set => Cookie_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>> Cookie_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LightType", LightType_Element.Data.ToResoniteLinkField());
members.Add("ShadowType", ShadowType_Element.Data.ToResoniteLinkField());
members.Add("ShadowStrength", ShadowStrength_Element.Data.ToResoniteLinkField());
members.Add("ShadowNearPlane", ShadowNearPlane_Element.Data.ToResoniteLinkField());
members.Add("ShadowMapResolution", ShadowMapResolution_Element.Data.ToResoniteLinkField());
members.Add("ShadowBias", ShadowBias_Element.Data.ToResoniteLinkField());
members.Add("ShadowNormalBias", ShadowNormalBias_Element.Data.ToResoniteLinkField());
members.Add("Cookie", Cookie_Element.Data.ToResoniteReference(context));
}

}
}
