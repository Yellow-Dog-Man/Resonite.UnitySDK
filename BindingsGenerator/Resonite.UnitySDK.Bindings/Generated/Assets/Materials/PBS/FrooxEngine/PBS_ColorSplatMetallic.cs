
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplatMetallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplatMetallic")]
public partial class PBS_ColorSplatMetallic : global::FrooxEngine.PBS_ColorSplat

{
    public global::System.Single Metallic0 { get => Metallic0_Element.Data; set => Metallic0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic0_Element = new();
public global::System.Single Metallic1 { get => Metallic1_Element.Data; set => Metallic1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic1_Element = new();
public global::System.Single Metallic2 { get => Metallic2_Element.Data; set => Metallic2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic2_Element = new();
public global::System.Single Metallic3 { get => Metallic3_Element.Data; set => Metallic3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic3_Element = new();
public global::System.Single Smoothness0 { get => Smoothness0_Element.Data; set => Smoothness0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness0_Element = new();
public global::System.Single Smoothness1 { get => Smoothness1_Element.Data; set => Smoothness1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness1_Element = new();
public global::System.Single Smoothness2 { get => Smoothness2_Element.Data; set => Smoothness2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness2_Element = new();
public global::System.Single Smoothness3 { get => Smoothness3_Element.Data; set => Smoothness3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap01 { get => MetallicMap01_Element.Data; set => MetallicMap01_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap01_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap23 { get => MetallicMap23_Element.Data; set => MetallicMap23_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap23_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic0", Metallic0_Element.Data.ToResoniteLinkField());
members.Add("Metallic1", Metallic1_Element.Data.ToResoniteLinkField());
members.Add("Metallic2", Metallic2_Element.Data.ToResoniteLinkField());
members.Add("Metallic3", Metallic3_Element.Data.ToResoniteLinkField());
members.Add("Smoothness0", Smoothness0_Element.Data.ToResoniteLinkField());
members.Add("Smoothness1", Smoothness1_Element.Data.ToResoniteLinkField());
members.Add("Smoothness2", Smoothness2_Element.Data.ToResoniteLinkField());
members.Add("Smoothness3", Smoothness3_Element.Data.ToResoniteLinkField());
members.Add("MetallicMap01", MetallicMap01_Element.Data.ToResoniteReference(context));
members.Add("MetallicMap23", MetallicMap23_Element.Data.ToResoniteReference(context));
}

}
}
