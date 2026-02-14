
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter
// Generated on: sobota 14. února 2026 8:58:34
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter")]
public partial class SphereEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single Radius;
public global::System.Boolean EmitFromShell;
public global::PhotonDust.SphereEmitterDirection DirectionMode;
public global::System.Single RandomDirectionWeight;
public UnityEngine.Vector3 ForcedDirection;
public global::PhotonDust.DirectionTransformMode DirectionTransformMode;
public UnityEngine.Vector3 DirectionReferencePoint;
public UnityEngine.Matrix3x3 DirectionPostTransform;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("ForcedDirection", ForcedDirection.ToResoniteLinkField());
members.Add("DirectionTransformMode", DirectionTransformMode.ToResoniteLinkField());
members.Add("DirectionReferencePoint", DirectionReferencePoint.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform.ToResoniteLinkField());
}

}
}
