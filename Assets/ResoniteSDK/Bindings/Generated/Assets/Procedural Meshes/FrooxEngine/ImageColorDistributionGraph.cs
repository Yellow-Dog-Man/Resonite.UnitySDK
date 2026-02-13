
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImageColorDistributionGraph
// Generated on: pátek 13. února 2026 23:21:35
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
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
