
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VertexColorSpecular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VertexColorSpecular")]
public partial class PBS_VertexColorSpecular : global::FrooxEngine.PBS_VertexColor, global::FrooxEngine.IPBS_Specular

{
    public UnityEngine.ColorX SpecularColor { get => SpecularColor_Element.Data; set => SpecularColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap { get => SpecularMap_Element.Data; set => SpecularMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SpecularMap_Element = new();
public global::FrooxEngine.PBS_VertexColorSpecular.ColorTarget VertexColorTarget { get => VertexColorTarget_Element.Data; set => VertexColorTarget_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PBS_VertexColorSpecular.ColorTarget>, global::FrooxEngine.PBS_VertexColorSpecular.ColorTarget> VertexColorTarget_Element = new();
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
members.Add("SpecularColor", SpecularColor_Element.Data.ToResoniteLinkField());
members.Add("SpecularMap", SpecularMap_Element.Data.ToResoniteReference(context));
members.Add("VertexColorTarget", VertexColorTarget_Element.Data.ToResoniteLinkField());
members.Add("_regular", _regular_Element.Data.ToResoniteReference(context));
members.Add("_transparent", _transparent_Element.Data.ToResoniteReference(context));
members.Add("_transparentFront", _transparentFront_Element.Data.ToResoniteReference(context));
}

}
}
