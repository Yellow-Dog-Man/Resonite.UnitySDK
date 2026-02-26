
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorMaskMetallic
// Generated on: čtvrtek 26. února 2026 10:03:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorMaskMetallic")]
public partial class PBS_ColorMaskMetallic : global::FrooxEngine.PBS_ColorMask

{
    public global::System.Single Metallic { get => Metallic_Element.Data; set => Metallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic_Element = new();
public global::System.Single Smoothness { get => Smoothness_Element.Data; set => Smoothness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap { get => MetallicMap_Element.Data; set => MetallicMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent { get => _transparent_Element.Data; set => _transparent_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _transparent_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _zwrite { get => _zwrite_Element.Data; set => _zwrite_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _zwrite_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic_Element.Data.ToResoniteLinkField());
members.Add("Smoothness", Smoothness_Element.Data.ToResoniteLinkField());
members.Add("MetallicMap", MetallicMap_Element.Data.ToResoniteReference(context));
members.Add("_regular", _regular_Element.Data.ToResoniteReference(context));
members.Add("_transparent", _transparent_Element.Data.ToResoniteReference(context));
members.Add("_zwrite", _zwrite_Element.Data.ToResoniteReference(context));
}

}
}
