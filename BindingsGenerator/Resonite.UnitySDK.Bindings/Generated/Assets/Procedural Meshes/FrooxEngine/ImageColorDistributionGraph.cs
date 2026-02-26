
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImageColorDistributionGraph
// Generated on: čtvrtek 26. února 2026 15:07:55
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Texture_Element = new();
public global::FrooxEngine.ImageColorDistributionGraph.Space ColorSpace { get => ColorSpace_Element.Data; set => ColorSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ImageColorDistributionGraph.Space>, global::FrooxEngine.ImageColorDistributionGraph.Space> ColorSpace_Element = new();
public global::System.Int32 MaxTextureSize { get => MaxTextureSize_Element.Data; set => MaxTextureSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxTextureSize_Element = new();
public global::System.Single BaseSize { get => BaseSize_Element.Data; set => BaseSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseSize_Element = new();
public global::System.Single AccumulateSize { get => AccumulateSize_Element.Data; set => AccumulateSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AccumulateSize_Element = new();
public global::System.Single MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSize_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public global::System.Single AlphaThreshold { get => AlphaThreshold_Element.Data; set => AlphaThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaThreshold_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("ColorSpace", ColorSpace_Element.ToLinkField(context));
members.Add("MaxTextureSize", MaxTextureSize_Element.ToLinkField(context));
members.Add("BaseSize", BaseSize_Element.ToLinkField(context));
members.Add("AccumulateSize", AccumulateSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("AlphaThreshold", AlphaThreshold_Element.ToLinkField(context));
}

}
}
