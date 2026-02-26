
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplatSpecular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplatSpecular")]
public partial class PBS_ColorSplatSpecular : global::FrooxEngine.PBS_ColorSplat

{
    public UnityEngine.ColorX SpecularColor0 { get => SpecularColor0_Element.Data; set => SpecularColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor0_Element = new();
public UnityEngine.ColorX SpecularColor1 { get => SpecularColor1_Element.Data; set => SpecularColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor1_Element = new();
public UnityEngine.ColorX SpecularColor2 { get => SpecularColor2_Element.Data; set => SpecularColor2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor2_Element = new();
public UnityEngine.ColorX SpecularColor3 { get => SpecularColor3_Element.Data; set => SpecularColor3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap0 { get => SpecularMap0_Element.Data; set => SpecularMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap1 { get => SpecularMap1_Element.Data; set => SpecularMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap2 { get => SpecularMap2_Element.Data; set => SpecularMap2_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap2_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap3 { get => SpecularMap3_Element.Data; set => SpecularMap3_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap3_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor0", SpecularColor0_Element.ToLinkField(context));
members.Add("SpecularColor1", SpecularColor1_Element.ToLinkField(context));
members.Add("SpecularColor2", SpecularColor2_Element.ToLinkField(context));
members.Add("SpecularColor3", SpecularColor3_Element.ToLinkField(context));
members.Add("SpecularMap0", SpecularMap0_Element.ToLinkReference(context));
members.Add("SpecularMap1", SpecularMap1_Element.ToLinkReference(context));
members.Add("SpecularMap2", SpecularMap2_Element.ToLinkReference(context));
members.Add("SpecularMap3", SpecularMap3_Element.ToLinkReference(context));
}

}
}
