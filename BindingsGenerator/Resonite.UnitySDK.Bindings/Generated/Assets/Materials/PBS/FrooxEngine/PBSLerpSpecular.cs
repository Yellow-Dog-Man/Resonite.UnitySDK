
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpSpecular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpSpecular")]
public partial class PBSLerpSpecular : global::FrooxEngine.PBSLerpMaterial

{
    public UnityEngine.ColorX SpecularColor0 { get => SpecularColor0_Element.Data; set => SpecularColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor0_Element = new();
public UnityEngine.ColorX SpecularColor1 { get => SpecularColor1_Element.Data; set => SpecularColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap0 { get => SpecularMap0_Element.Data; set => SpecularMap0_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap1 { get => SpecularMap1_Element.Data; set => SpecularMap1_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor0", SpecularColor0_Element.ToLinkField(context));
members.Add("SpecularColor1", SpecularColor1_Element.ToLinkField(context));
members.Add("SpecularMap0", SpecularMap0_Element.ToLinkReference(context));
members.Add("SpecularMap1", SpecularMap1_Element.ToLinkReference(context));
}

}
}
