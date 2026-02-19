
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ConeEmitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ConeEmitter")]
public partial class ConeEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single BaseRadius;
public global::System.Single Height;
public global::System.Boolean EmitFromShell;
public global::PhotonDust.ConeEmitterDirection DirectionMode;
public global::System.Single RandomDirectionWeight;
public UnityEngine.Vector3 Direction;
public global::PhotonDust.DirectionTransformMode DirectionTransformMode;
public UnityEngine.Vector3 RelativeDirectionReferencePoint;
public UnityEngine.Matrix3x3 DirectionPostTransform;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseRadius", BaseRadius.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("DirectionTransformMode", DirectionTransformMode.ToResoniteLinkField());
members.Add("RelativeDirectionReferencePoint", RelativeDirectionReferencePoint.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform.ToResoniteLinkField());
}

}
}
