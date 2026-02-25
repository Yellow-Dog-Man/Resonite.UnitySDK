
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_RimMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_RimMaterial")]
public abstract partial class PBS_RimMaterial : global::FrooxEngine.MaterialProvider

{
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX AlbedoColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public UnityEngine.ColorX RimColor;
public global::System.Single RimPower;
public global::System.Single GammaCurve;
public global::System.Boolean Transparent;
public global::System.Boolean ForceZWrite;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap.ToResoniteReference(context));
members.Add("RimColor", RimColor.ToResoniteLinkField());
members.Add("RimPower", RimPower.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("Transparent", Transparent.ToResoniteLinkField());
members.Add("ForceZWrite", ForceZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
