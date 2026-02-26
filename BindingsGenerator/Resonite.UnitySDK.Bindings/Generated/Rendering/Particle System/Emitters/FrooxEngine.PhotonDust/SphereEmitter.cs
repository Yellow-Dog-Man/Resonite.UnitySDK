
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SphereEmitter")]
public partial class SphereEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Boolean EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EmitFromShell_Element = new();
public global::PhotonDust.SphereEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.SphereEmitterDirection>, global::PhotonDust.SphereEmitterDirection> DirectionMode_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public UnityEngine.Vector3 ForcedDirection { get => ForcedDirection_Element.Data; set => ForcedDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ForcedDirection_Element = new();
public global::PhotonDust.DirectionTransformMode DirectionTransformMode { get => DirectionTransformMode_Element.Data; set => DirectionTransformMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.DirectionTransformMode>, global::PhotonDust.DirectionTransformMode> DirectionTransformMode_Element = new();
public UnityEngine.Vector3 DirectionReferencePoint { get => DirectionReferencePoint_Element.Data; set => DirectionReferencePoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> DirectionReferencePoint_Element = new();
public UnityEngine.Matrix3x3 DirectionPostTransform { get => DirectionPostTransform_Element.Data; set => DirectionPostTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Matrix3x3>, UnityEngine.Matrix3x3> DirectionPostTransform_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("EmitFromShell", EmitFromShell_Element.ToLinkField(context));
members.Add("DirectionMode", DirectionMode_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
members.Add("ForcedDirection", ForcedDirection_Element.ToLinkField(context));
members.Add("DirectionTransformMode", DirectionTransformMode_Element.ToLinkField(context));
members.Add("DirectionReferencePoint", DirectionReferencePoint_Element.ToLinkField(context));
members.Add("DirectionPostTransform", DirectionPostTransform_Element.ToLinkField(context));
}

}
}
