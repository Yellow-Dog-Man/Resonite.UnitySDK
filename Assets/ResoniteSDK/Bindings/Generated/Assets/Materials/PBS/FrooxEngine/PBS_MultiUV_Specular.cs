
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Specular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Specular")]
public partial class PBS_MultiUV_Specular : global::FrooxEngine.PBS_MultiUV_Material, global::FrooxEngine.IPBS_Specular

{
    public UnityEngine.ColorX SpecularColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap;
public UnityEngine.Vector2 SpecularMapScale;
public UnityEngine.Vector2 SpecularMapOffset;
public global::System.Int32 SpecularMapUV;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("SpecularMap", new ResoniteLink.Reference() { });
members.Add("SpecularMapScale", SpecularMapScale.ToResoniteLinkField());
members.Add("SpecularMapOffset", SpecularMapOffset.ToResoniteLinkField());
members.Add("SpecularMapUV", SpecularMapUV.ToResoniteLinkField());
}

}
}
