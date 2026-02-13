
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DepthProjectionMaterial
// Generated on: pátek 13. února 2026 5:51:06
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DepthProjectionMaterial")]
public partial class DepthProjectionMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Color;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Depth;
public global::FrooxEngine.DepthEncoding DepthEncoding;
public UnityEngine.Vector2 ColorTextureOffset;
public UnityEngine.Vector2 ColorTextureScale;
public UnityEngine.Vector2 DepthTextureOffset;
public UnityEngine.Vector2 DepthTextureScale;
public global::System.Single DepthFrom;
public global::System.Single DepthTo;
public UnityEngine.Vector2 FieldOfView;
public global::System.Single NearClip;
public global::System.Single FarClip;
public global::System.Single DiscardThreshold;
public global::System.Single DiscardOffset;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.ZWrite ZWrite;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", new ResoniteLink.Reference() { });
members.Add("Depth", new ResoniteLink.Reference() { });
members.Add("DepthEncoding", DepthEncoding.ToResoniteLinkField());
members.Add("ColorTextureOffset", ColorTextureOffset.ToResoniteLinkField());
members.Add("ColorTextureScale", ColorTextureScale.ToResoniteLinkField());
members.Add("DepthTextureOffset", DepthTextureOffset.ToResoniteLinkField());
members.Add("DepthTextureScale", DepthTextureScale.ToResoniteLinkField());
members.Add("DepthFrom", DepthFrom.ToResoniteLinkField());
members.Add("DepthTo", DepthTo.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("NearClip", NearClip.ToResoniteLinkField());
members.Add("FarClip", FarClip.ToResoniteLinkField());
members.Add("DiscardThreshold", DiscardThreshold.ToResoniteLinkField());
members.Add("DiscardOffset", DiscardOffset.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
}

}
}
