
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DisplaceMetallic
// Generated on: čtvrtek 19. února 2026 7:58:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DisplaceMetallic")]
public partial class PBS_DisplaceMetallic : global::FrooxEngine.PBS_DisplaceMaterial, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic;
public global::System.Single Smoothness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Smoothness", Smoothness.ToResoniteLinkField());
members.Add("MetallicMap", MetallicMap.ToResoniteReference(context));
members.Add("_regular", _regular.ToResoniteReference(context));
members.Add("_transparent", _transparent.ToResoniteReference(context));
}

}
}
