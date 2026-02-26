
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_MultiUV_Metallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_MultiUV_Metallic")]
public partial class PBS_MultiUV_Metallic : global::FrooxEngine.PBS_MultiUV_Material, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic { get => Metallic_Element.Data; set => Metallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic_Element = new();
public global::System.Single Smoothness { get => Smoothness_Element.Data; set => Smoothness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap { get => MetallicMap_Element.Data; set => MetallicMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap_Element = new();
public UnityEngine.Vector2 MetallicMapScale { get => MetallicMapScale_Element.Data; set => MetallicMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MetallicMapScale_Element = new();
public UnityEngine.Vector2 MetallicMapOffset { get => MetallicMapOffset_Element.Data; set => MetallicMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MetallicMapOffset_Element = new();
public global::System.Int32 MetallicMapUV { get => MetallicMapUV_Element.Data; set => MetallicMapUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MetallicMapUV_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic_Element.Data.ToResoniteLinkField());
members.Add("Smoothness", Smoothness_Element.Data.ToResoniteLinkField());
members.Add("MetallicMap", MetallicMap_Element.Data.ToResoniteReference(context));
members.Add("MetallicMapScale", MetallicMapScale_Element.Data.ToResoniteLinkField());
members.Add("MetallicMapOffset", MetallicMapOffset_Element.Data.ToResoniteLinkField());
members.Add("MetallicMapUV", MetallicMapUV_Element.Data.ToResoniteLinkField());
}

}
}
