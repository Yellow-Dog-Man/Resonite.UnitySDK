
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Specular
// Generated on: čtvrtek 26. února 2026 12:26:47
// Resonite version: 2026.2.26.702
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
    public UnityEngine.ColorX SpecularColor { get => SpecularColor_Element.Data; set => SpecularColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap { get => SpecularMap_Element.Data; set => SpecularMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap_Element = new();
public UnityEngine.Vector2 SpecularMapScale { get => SpecularMapScale_Element.Data; set => SpecularMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SpecularMapScale_Element = new();
public UnityEngine.Vector2 SpecularMapOffset { get => SpecularMapOffset_Element.Data; set => SpecularMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> SpecularMapOffset_Element = new();
public global::System.Int32 SpecularMapUV { get => SpecularMapUV_Element.Data; set => SpecularMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SpecularMapUV_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor_Element.ToLinkField(context));
members.Add("SpecularMap", SpecularMap_Element.ToLinkReference(context));
members.Add("SpecularMapScale", SpecularMapScale_Element.ToLinkField(context));
members.Add("SpecularMapOffset", SpecularMapOffset_Element.ToLinkField(context));
members.Add("SpecularMapUV", SpecularMapUV_Element.ToLinkField(context));
}

}
}
