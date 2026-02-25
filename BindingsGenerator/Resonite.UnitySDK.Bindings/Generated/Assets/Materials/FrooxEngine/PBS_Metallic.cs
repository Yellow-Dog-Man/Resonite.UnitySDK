
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Metallic
// Generated on: středa 25. února 2026 16:13:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Metallic")]
public partial class PBS_Metallic : global::FrooxEngine.PBS_Material, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic;
public global::System.Single Smoothness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Smoothness", Smoothness.ToResoniteLinkField());
members.Add("MetallicMap", MetallicMap.ToResoniteReference(context));
}

}
}
