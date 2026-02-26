
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.CircleEmitter
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.CircleEmitter")]
public partial class CircleEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public UnityEngine.Vector2 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Scale_Element = new();
public global::System.Boolean EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EmitFromShell_Element = new();
public global::PhotonDust.CircleEmitterAlignment CircleAlignment { get => CircleAlignment_Element.Data; set => CircleAlignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.CircleEmitterAlignment>, global::PhotonDust.CircleEmitterAlignment> CircleAlignment_Element = new();
public global::PhotonDust.CircleEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.CircleEmitterDirection>, global::PhotonDust.CircleEmitterDirection> DirectionMode_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::PhotonDust.DirectionTransformMode DirectionTransformMode { get => DirectionTransformMode_Element.Data; set => DirectionTransformMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.DirectionTransformMode>, global::PhotonDust.DirectionTransformMode> DirectionTransformMode_Element = new();
public UnityEngine.Matrix3x3 DirectionPostTransform { get => DirectionPostTransform_Element.Data; set => DirectionPostTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Matrix3x3>, UnityEngine.Matrix3x3> DirectionPostTransform_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("EmitFromShell", EmitFromShell_Element.ToLinkField(context));
members.Add("CircleAlignment", CircleAlignment_Element.ToLinkField(context));
members.Add("DirectionMode", DirectionMode_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("DirectionTransformMode", DirectionTransformMode_Element.ToLinkField(context));
members.Add("DirectionPostTransform", DirectionPostTransform_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
}

}
}
