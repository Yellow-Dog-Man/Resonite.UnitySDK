
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnlitDistanceLerpMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnlitDistanceLerpMaterial")]
public partial class UnlitDistanceLerpMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Boolean LocalSpace;
public UnityEngine.Vector3 Point;
public global::System.Single Distance;
public global::System.Single TransitionRange;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture;
public UnityEngine.Vector2 NearTextureScale;
public UnityEngine.Vector2 NearTextureOffset;
public UnityEngine.Vector2 FarTextureScale;
public UnityEngine.Vector2 FarTextureOffset;
public UnityEngine.ColorX NearColor;
public UnityEngine.ColorX FarColor;
public global::System.Boolean UseVertexColors;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalSpace", LocalSpace.ToResoniteLinkField());
members.Add("Point", Point.ToResoniteLinkField());
members.Add("Distance", Distance.ToResoniteLinkField());
members.Add("TransitionRange", TransitionRange.ToResoniteLinkField());
members.Add("NearTexture", NearTexture.ToResoniteReference(context));
members.Add("FarTexture", FarTexture.ToResoniteReference(context));
members.Add("NearTextureScale", NearTextureScale.ToResoniteLinkField());
members.Add("NearTextureOffset", NearTextureOffset.ToResoniteLinkField());
members.Add("FarTextureScale", FarTextureScale.ToResoniteLinkField());
members.Add("FarTextureOffset", FarTextureOffset.ToResoniteLinkField());
members.Add("NearColor", NearColor.ToResoniteLinkField());
members.Add("FarColor", FarColor.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
