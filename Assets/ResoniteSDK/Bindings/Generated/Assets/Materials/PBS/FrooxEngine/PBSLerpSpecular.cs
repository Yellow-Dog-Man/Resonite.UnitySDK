
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpSpecular
// Generated on: pátek 13. února 2026 5:51:06
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpSpecular")]
public partial class PBSLerpSpecular : global::FrooxEngine.PBSLerpMaterial

{
    public UnityEngine.ColorX SpecularColor0;
public UnityEngine.ColorX SpecularColor1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SpecularColor0", SpecularColor0.ToResoniteLinkField());
members.Add("SpecularColor1", SpecularColor1.ToResoniteLinkField());
members.Add("SpecularMap0", new ResoniteLink.Reference() { });
members.Add("SpecularMap1", new ResoniteLink.Reference() { });
}

}
}
