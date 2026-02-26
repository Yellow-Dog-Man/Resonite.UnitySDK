
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ConeEmitter
// Generated on: čtvrtek 26. února 2026 10:04:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ConeEmitter")]
public partial class ConeEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single BaseRadius { get => BaseRadius_Element.Data; set => BaseRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseRadius_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Boolean EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EmitFromShell_Element = new();
public global::PhotonDust.ConeEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ConeEmitterDirection>, global::PhotonDust.ConeEmitterDirection> DirectionMode_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::PhotonDust.DirectionTransformMode DirectionTransformMode { get => DirectionTransformMode_Element.Data; set => DirectionTransformMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.DirectionTransformMode>, global::PhotonDust.DirectionTransformMode> DirectionTransformMode_Element = new();
public UnityEngine.Vector3 RelativeDirectionReferencePoint { get => RelativeDirectionReferencePoint_Element.Data; set => RelativeDirectionReferencePoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RelativeDirectionReferencePoint_Element = new();
public UnityEngine.Matrix3x3 DirectionPostTransform { get => DirectionPostTransform_Element.Data; set => DirectionPostTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Matrix3x3>, UnityEngine.Matrix3x3> DirectionPostTransform_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseRadius", BaseRadius_Element.Data.ToResoniteLinkField());
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
members.Add("EmitFromShell", EmitFromShell_Element.Data.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode_Element.Data.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.Data.ToResoniteLinkField());
members.Add("Direction", Direction_Element.Data.ToResoniteLinkField());
members.Add("DirectionTransformMode", DirectionTransformMode_Element.Data.ToResoniteLinkField());
members.Add("RelativeDirectionReferencePoint", RelativeDirectionReferencePoint_Element.Data.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform_Element.Data.ToResoniteLinkField());
}

}
}
