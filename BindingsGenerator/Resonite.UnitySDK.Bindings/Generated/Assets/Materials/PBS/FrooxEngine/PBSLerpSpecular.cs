
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpSpecular
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpSpecular")]
public partial class PBSLerpSpecular : global::FrooxEngine.PBSLerpMaterial

{
    public UnityEngine.ColorX SpecularColor0;
public UnityEngine.ColorX SpecularColor1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor0", SpecularColor0.ToResoniteLinkField());
members.Add("SpecularColor1", SpecularColor1.ToResoniteLinkField());
members.Add("SpecularMap0", SpecularMap0.ToResoniteReference(context));
members.Add("SpecularMap1", SpecularMap1.ToResoniteReference(context));
}

}
}
