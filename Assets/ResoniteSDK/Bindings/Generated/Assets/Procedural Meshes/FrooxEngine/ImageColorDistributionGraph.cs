
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImageColorDistributionGraph
// Generated on: sobota 14. února 2026 8:56:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImageColorDistributionGraph")]
public partial class ImageColorDistributionGraph : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;
public global::FrooxEngine.ImageColorDistributionGraph.Space ColorSpace;
public global::System.Int32 MaxTextureSize;
public global::System.Single BaseSize;
public global::System.Single AccumulateSize;
public global::System.Single MaxSize;
public UnityEngine.Vector3 Scale;
public global::System.Single AlphaThreshold;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("ColorSpace", ColorSpace.ToResoniteLinkField());
members.Add("MaxTextureSize", MaxTextureSize.ToResoniteLinkField());
members.Add("BaseSize", BaseSize.ToResoniteLinkField());
members.Add("AccumulateSize", AccumulateSize.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("AlphaThreshold", AlphaThreshold.ToResoniteLinkField());
}

}
}
