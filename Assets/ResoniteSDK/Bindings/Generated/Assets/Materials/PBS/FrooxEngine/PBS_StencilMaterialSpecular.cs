
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_StencilMaterialSpecular
// Generated on: pátek 13. února 2026 23:21:33
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("SpecularMap", new ResoniteLink.Reference() { });
members.Add("_regular", new ResoniteLink.Reference() { });
}

}
}
