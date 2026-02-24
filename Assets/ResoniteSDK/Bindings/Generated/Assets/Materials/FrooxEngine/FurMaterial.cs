
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FurMaterial
// Generated on: úterý 24. února 2026 18:17:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FurMaterial")]
public partial class FurMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX Color;
public UnityEngine.ColorX SpecularColor;
public global::System.Single Shininess;
public global::System.Single Gloss;
public UnityEngine.ColorX RimColor;
public global::System.Single RimPower;
public global::System.Single FurLength;
public global::System.Single FurHardness;
public global::System.Single FurThinness;
public global::System.Single FurShading;
public global::System.Single FurColoring;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Base;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Noise;
public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public global::System.Single AlphaCutoff;
public UnityEngine.Vector4 ForceGlobal;
public UnityEngine.Vector4 ForceLocal;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("Shininess", Shininess.ToResoniteLinkField());
members.Add("Gloss", Gloss.ToResoniteLinkField());
members.Add("RimColor", RimColor.ToResoniteLinkField());
members.Add("RimPower", RimPower.ToResoniteLinkField());
members.Add("FurLength", FurLength.ToResoniteLinkField());
members.Add("FurHardness", FurHardness.ToResoniteLinkField());
members.Add("FurThinness", FurThinness.ToResoniteLinkField());
members.Add("FurShading", FurShading.ToResoniteLinkField());
members.Add("FurColoring", FurColoring.ToResoniteLinkField());
members.Add("Base", Base.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("Noise", Noise.ToResoniteReference(context));
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("ForceGlobal", ForceGlobal.ToResoniteLinkField());
members.Add("ForceLocal", ForceLocal.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
