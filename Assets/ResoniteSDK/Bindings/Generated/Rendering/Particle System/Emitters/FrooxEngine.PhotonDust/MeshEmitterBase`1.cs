
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshEmitterBase<>
// Generated on: čtvrtek 19. února 2026 8:00:20
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.MeshEmitterBase<>")]
public abstract partial class MeshEmitterBase<E> : global::FrooxEngine.PhotonDust.TransformableEmitter<E>
	

{
    public global::PhotonDust.MeshEmissionSource EmitFrom;
public global::System.Boolean UseVertexColors;
public global::System.Boolean UniformDistribution;
public global::PhotonDust.MeshEmitterDirection DirectionMode;
public UnityEngine.Vector3 Direction;
public global::System.Single RandomDirectionWeight;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> ColorTexture;
public global::Elements.Assets.WrapMode WrapMode;
public UnityEngine.Vector2 UVOffset;
public UnityEngine.Vector2 UVScale;
public global::System.Nullable<UnityEngine.Rect> ClipRect;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EmitFrom", EmitFrom.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("UniformDistribution", UniformDistribution.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("ColorTexture", ColorTexture.ToResoniteReference(context));
members.Add("WrapMode", WrapMode.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ClipRect", ClipRect.ToResoniteLinkField());
}

}
}
