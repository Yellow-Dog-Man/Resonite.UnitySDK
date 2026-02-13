
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DistanceLerpMetallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DistanceLerpMetallic")]
public partial class PBS_DistanceLerpMetallic : global::FrooxEngine.PBS_DistanceLerpMaterial

{
    public global::System.Single Metallic;
public global::System.Single Smoothness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Smoothness", Smoothness.ToResoniteLinkField());
members.Add("MetallicMap", new ResoniteLink.Reference() { });
members.Add("_regular", new ResoniteLink.Reference() { });
members.Add("_transparent", new ResoniteLink.Reference() { });
}

}
}
