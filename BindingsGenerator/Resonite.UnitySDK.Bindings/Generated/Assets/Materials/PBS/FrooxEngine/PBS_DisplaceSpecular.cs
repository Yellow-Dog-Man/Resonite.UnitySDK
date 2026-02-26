
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DisplaceSpecular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DisplaceSpecular")]
public partial class PBS_DisplaceSpecular : global::FrooxEngine.PBS_DisplaceMaterial, global::FrooxEngine.IPBS_Specular

{
    public UnityEngine.ColorX SpecularColor { get => SpecularColor_Element.Data; set => SpecularColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap { get => SpecularMap_Element.Data; set => SpecularMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent { get => _transparent_Element.Data; set => _transparent_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _transparent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor_Element.ToLinkField(context));
members.Add("SpecularMap", SpecularMap_Element.ToLinkReference(context));
members.Add("_regular", _regular_Element.ToLinkReference(context));
members.Add("_transparent", _transparent_Element.ToLinkReference(context));
}

}
}
