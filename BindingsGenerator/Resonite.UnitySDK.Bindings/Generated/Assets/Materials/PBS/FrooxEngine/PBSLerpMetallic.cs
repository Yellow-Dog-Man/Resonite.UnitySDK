
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpMetallic
// Generated on: čtvrtek 26. února 2026 12:26:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpMetallic")]
public partial class PBSLerpMetallic : global::FrooxEngine.PBSLerpMaterial

{
    public global::System.Single Metallic0 { get => Metallic0_Element.Data; set => Metallic0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic0_Element = new();
public global::System.Single Metallic1 { get => Metallic1_Element.Data; set => Metallic1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic1_Element = new();
public global::System.Single Smoothness0 { get => Smoothness0_Element.Data; set => Smoothness0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness0_Element = new();
public global::System.Single Smoothness1 { get => Smoothness1_Element.Data; set => Smoothness1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap0 { get => MetallicMap0_Element.Data; set => MetallicMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap1 { get => MetallicMap1_Element.Data; set => MetallicMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic0", Metallic0_Element.ToLinkField(context));
members.Add("Metallic1", Metallic1_Element.ToLinkField(context));
members.Add("Smoothness0", Smoothness0_Element.ToLinkField(context));
members.Add("Smoothness1", Smoothness1_Element.ToLinkField(context));
members.Add("MetallicMap0", MetallicMap0_Element.ToLinkReference(context));
members.Add("MetallicMap1", MetallicMap1_Element.ToLinkReference(context));
}

}
}
