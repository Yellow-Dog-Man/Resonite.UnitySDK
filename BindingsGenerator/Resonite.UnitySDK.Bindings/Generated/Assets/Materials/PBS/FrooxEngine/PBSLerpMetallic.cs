
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpMetallic
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpMetallic")]
public partial class PBSLerpMetallic : global::FrooxEngine.PBSLerpMaterial

{
    public global::System.Single Metallic0;
public global::System.Single Metallic1;
public global::System.Single Smoothness0;
public global::System.Single Smoothness1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic0", Metallic0.ToResoniteLinkField());
members.Add("Metallic1", Metallic1.ToResoniteLinkField());
members.Add("Smoothness0", Smoothness0.ToResoniteLinkField());
members.Add("Smoothness1", Smoothness1.ToResoniteLinkField());
members.Add("MetallicMap0", MetallicMap0.ToResoniteReference(context));
members.Add("MetallicMap1", MetallicMap1.ToResoniteReference(context));
}

}
}
