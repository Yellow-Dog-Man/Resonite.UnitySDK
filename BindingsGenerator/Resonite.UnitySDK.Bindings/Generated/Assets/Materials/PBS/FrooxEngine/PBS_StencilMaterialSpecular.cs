
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_StencilMaterialSpecular
// Generated on: čtvrtek 26. února 2026 15:07:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_StencilMaterialSpecular")]
public partial class PBS_StencilMaterialSpecular : global::FrooxEngine.PBS_StencilMaterial

{
    public UnityEngine.ColorX SpecularColor { get => SpecularColor_Element.Data; set => SpecularColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap { get => SpecularMap_Element.Data; set => SpecularMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor_Element.ToLinkField(context));
members.Add("SpecularMap", SpecularMap_Element.ToLinkReference(context));
members.Add("_regular", _regular_Element.ToLinkReference(context));
}

}
}
