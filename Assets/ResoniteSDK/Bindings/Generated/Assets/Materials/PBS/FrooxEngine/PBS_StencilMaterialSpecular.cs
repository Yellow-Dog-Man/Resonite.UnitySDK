
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_StencilMaterialSpecular
// Generated on: sobota 14. února 2026 8:56:56
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.ColorX SpecularColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("SpecularMap", SpecularMap.ToResoniteReference(context));
members.Add("_regular", _regular.ToResoniteReference(context));
}

}
}
