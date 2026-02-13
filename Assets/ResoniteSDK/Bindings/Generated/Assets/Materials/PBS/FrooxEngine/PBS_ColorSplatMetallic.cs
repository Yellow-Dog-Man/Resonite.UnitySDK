
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplatMetallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplatMetallic")]
public partial class PBS_ColorSplatMetallic : global::FrooxEngine.PBS_ColorSplat

{
    public global::System.Single Metallic0;
public global::System.Single Metallic1;
public global::System.Single Metallic2;
public global::System.Single Metallic3;
public global::System.Single Smoothness0;
public global::System.Single Smoothness1;
public global::System.Single Smoothness2;
public global::System.Single Smoothness3;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap01;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap23;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Metallic0", Metallic0.ToResoniteLinkField());
members.Add("Metallic1", Metallic1.ToResoniteLinkField());
members.Add("Metallic2", Metallic2.ToResoniteLinkField());
members.Add("Metallic3", Metallic3.ToResoniteLinkField());
members.Add("Smoothness0", Smoothness0.ToResoniteLinkField());
members.Add("Smoothness1", Smoothness1.ToResoniteLinkField());
members.Add("Smoothness2", Smoothness2.ToResoniteLinkField());
members.Add("Smoothness3", Smoothness3.ToResoniteLinkField());
members.Add("MetallicMap01", new ResoniteLink.Reference() { });
members.Add("MetallicMap23", new ResoniteLink.Reference() { });
}

}
}
