
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter
// Generated on: středa 25. února 2026 16:14:17
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.CylinderEmitter")]
public partial class CylinderEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single Radius;
public global::System.Single Height;
public global::System.Boolean EmitFromShell;
public global::System.Boolean ExcludeCaps;
public global::PhotonDust.CylinderEmitterDirection DirectionMode;
public global::PhotonDust.CylinderEmitterCapsDirection CapsDirectionMode;
public global::System.Single RandomDirectionWeight;
public UnityEngine.Vector3 Direction;
public global::PhotonDust.DirectionTransformMode DirectionTransformMode;
public UnityEngine.Matrix3x3 DirectionPostTransform;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell.ToResoniteLinkField());
members.Add("ExcludeCaps", ExcludeCaps.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("CapsDirectionMode", CapsDirectionMode.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("DirectionTransformMode", DirectionTransformMode.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform.ToResoniteLinkField());
}

}
}
