
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Specular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Specular")]
public partial class PBS_MultiUV_Specular : global::FrooxEngine.PBS_MultiUV_Material, global::FrooxEngine.IPBS_Specular

{
    public UnityEngine.ColorX SpecularColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap;
public UnityEngine.Vector2 SpecularMapScale;
public UnityEngine.Vector2 SpecularMapOffset;
public global::System.Int32 SpecularMapUV;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("SpecularMap", SpecularMap.ToResoniteReference(context));
members.Add("SpecularMapScale", SpecularMapScale.ToResoniteLinkField());
members.Add("SpecularMapOffset", SpecularMapOffset.ToResoniteLinkField());
members.Add("SpecularMapUV", SpecularMapUV.ToResoniteLinkField());
}

}
}
