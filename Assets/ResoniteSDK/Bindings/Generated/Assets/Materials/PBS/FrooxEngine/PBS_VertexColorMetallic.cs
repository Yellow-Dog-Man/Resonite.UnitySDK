
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VertexColorMetallic
// Generated on: čtvrtek 19. února 2026 7:58:51
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VertexColorMetallic")]
public partial class PBS_VertexColorMetallic : global::FrooxEngine.PBS_VertexColor, global::FrooxEngine.IPBS_Metallic

{
    public global::System.Single Metallic;
public global::System.Single Smoothness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MetallicMap;
public global::FrooxEngine.PBS_VertexColorMetallic.ColorTarget VertexColorTarget;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparentFront;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metallic", Metallic.ToResoniteLinkField());
members.Add("Smoothness", Smoothness.ToResoniteLinkField());
members.Add("MetallicMap", MetallicMap.ToResoniteReference(context));
members.Add("VertexColorTarget", VertexColorTarget.ToResoniteLinkField());
members.Add("_regular", _regular.ToResoniteReference(context));
members.Add("_transparent", _transparent.ToResoniteReference(context));
members.Add("_transparentFront", _transparentFront.ToResoniteReference(context));
}

}
}
