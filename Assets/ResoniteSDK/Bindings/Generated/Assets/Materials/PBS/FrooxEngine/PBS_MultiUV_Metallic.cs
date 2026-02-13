
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Metallic
// Generated on: pátek 13. února 2026 5:51:06
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Metallic")]
public partial class PBS_MultiUV_Metallic : global::FrooxEngine.PBS_MultiUV_Material, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic;
public global::System.Single Smoothness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap;
public UnityEngine.Vector2 MetallicMapScale;
public UnityEngine.Vector2 MetallicMapOffset;
public global::System.Int32 MetallicMapUV;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Smoothness", Smoothness.ToResoniteLinkField());
members.Add("MetallicMap", new ResoniteLink.Reference() { });
members.Add("MetallicMapScale", MetallicMapScale.ToResoniteLinkField());
members.Add("MetallicMapOffset", MetallicMapOffset.ToResoniteLinkField());
members.Add("MetallicMapUV", MetallicMapUV.ToResoniteLinkField());
}

}
}
