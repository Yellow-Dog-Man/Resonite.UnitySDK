
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter
// Generated on: čtvrtek 19. února 2026 8:00:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter")]
public partial class BoxEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public UnityEngine.Vector3 Size;
public global::System.Boolean EmitFromShell;
public global::PhotonDust.BoxEmitterDirection DirectionMode;
public UnityEngine.Vector3 Direction;
public global::PhotonDust.DirectionTransformMode DirectionTransformMode;
public global::System.Single RandomDirectionWeight;
public UnityEngine.Matrix3x3 DirectionPostTransform;
public UnityEngine.ColorX Color0;
public UnityEngine.ColorX Color1;
public UnityEngine.ColorX Color2;
public UnityEngine.ColorX Color3;
public UnityEngine.ColorX Color4;
public UnityEngine.ColorX Color5;
public UnityEngine.ColorX Color6;
public UnityEngine.ColorX Color7;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("DirectionTransformMode", DirectionTransformMode.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform.ToResoniteLinkField());
members.Add("Color0", Color0.ToResoniteLinkField());
members.Add("Color1", Color1.ToResoniteLinkField());
members.Add("Color2", Color2.ToResoniteLinkField());
members.Add("Color3", Color3.ToResoniteLinkField());
members.Add("Color4", Color4.ToResoniteLinkField());
members.Add("Color5", Color5.ToResoniteLinkField());
members.Add("Color6", Color6.ToResoniteLinkField());
members.Add("Color7", Color7.ToResoniteLinkField());
}

}
}
