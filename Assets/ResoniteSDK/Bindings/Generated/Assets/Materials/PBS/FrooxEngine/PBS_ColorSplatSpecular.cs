
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplatSpecular
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplatSpecular")]
public partial class PBS_ColorSplatSpecular : global::FrooxEngine.PBS_ColorSplat

{
    public UnityEngine.ColorX SpecularColor0;
public UnityEngine.ColorX SpecularColor1;
public UnityEngine.ColorX SpecularColor2;
public UnityEngine.ColorX SpecularColor3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap2;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor0", SpecularColor0.ToResoniteLinkField());
members.Add("SpecularColor1", SpecularColor1.ToResoniteLinkField());
members.Add("SpecularColor2", SpecularColor2.ToResoniteLinkField());
members.Add("SpecularColor3", SpecularColor3.ToResoniteLinkField());
members.Add("SpecularMap0", SpecularMap0.ToResoniteReference(context));
members.Add("SpecularMap1", SpecularMap1.ToResoniteReference(context));
members.Add("SpecularMap2", SpecularMap2.ToResoniteReference(context));
members.Add("SpecularMap3", SpecularMap3.ToResoniteReference(context));
}

}
}
