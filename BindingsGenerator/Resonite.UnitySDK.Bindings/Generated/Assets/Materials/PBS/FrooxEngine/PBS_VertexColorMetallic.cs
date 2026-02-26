
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VertexColorMetallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VertexColorMetallic")]
public partial class PBS_VertexColorMetallic : global::FrooxEngine.PBS_VertexColor, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic { get => Metallic_Element.Data; set => Metallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Metallic_Element = new();
public global::System.Single Smoothness { get => Smoothness_Element.Data; set => Smoothness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothness_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap { get => MetallicMap_Element.Data; set => MetallicMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MetallicMap_Element = new();
public global::FrooxEngine.PBS_VertexColorMetallic.ColorTarget VertexColorTarget { get => VertexColorTarget_Element.Data; set => VertexColorTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PBS_VertexColorMetallic.ColorTarget>, global::FrooxEngine.PBS_VertexColorMetallic.ColorTarget> VertexColorTarget_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular { get => _regular_Element.Data; set => _regular_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _regular_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent { get => _transparent_Element.Data; set => _transparent_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _transparent_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparentFront { get => _transparentFront_Element.Data; set => _transparentFront_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _transparentFront_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic_Element.ToLinkField(context));
members.Add("Smoothness", Smoothness_Element.ToLinkField(context));
members.Add("MetallicMap", MetallicMap_Element.ToLinkReference(context));
members.Add("VertexColorTarget", VertexColorTarget_Element.ToLinkField(context));
members.Add("_regular", _regular_Element.ToLinkReference(context));
members.Add("_transparent", _transparent_Element.ToLinkReference(context));
members.Add("_transparentFront", _transparentFront_Element.ToLinkReference(context));
}

}
}
