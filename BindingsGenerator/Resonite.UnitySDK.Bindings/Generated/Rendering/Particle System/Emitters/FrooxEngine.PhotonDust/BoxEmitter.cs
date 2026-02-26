
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BoxEmitter")]
public partial class BoxEmitter : global::FrooxEngine.PhotonDust.TransformableEmitter<global::System.Object>

{
    public UnityEngine.Vector3 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Size_Element = new();
public global::System.Boolean EmitFromShell { get => EmitFromShell_Element.Data; set => EmitFromShell_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EmitFromShell_Element = new();
public global::PhotonDust.BoxEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.BoxEmitterDirection>, global::PhotonDust.BoxEmitterDirection> DirectionMode_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::PhotonDust.DirectionTransformMode DirectionTransformMode { get => DirectionTransformMode_Element.Data; set => DirectionTransformMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.DirectionTransformMode>, global::PhotonDust.DirectionTransformMode> DirectionTransformMode_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public UnityEngine.Matrix3x3 DirectionPostTransform { get => DirectionPostTransform_Element.Data; set => DirectionPostTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Matrix3x3>, UnityEngine.Matrix3x3> DirectionPostTransform_Element = new();
public UnityEngine.ColorX Color0 { get => Color0_Element.Data; set => Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color0_Element = new();
public UnityEngine.ColorX Color1 { get => Color1_Element.Data; set => Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color1_Element = new();
public UnityEngine.ColorX Color2 { get => Color2_Element.Data; set => Color2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color2_Element = new();
public UnityEngine.ColorX Color3 { get => Color3_Element.Data; set => Color3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color3_Element = new();
public UnityEngine.ColorX Color4 { get => Color4_Element.Data; set => Color4_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color4_Element = new();
public UnityEngine.ColorX Color5 { get => Color5_Element.Data; set => Color5_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color5_Element = new();
public UnityEngine.ColorX Color6 { get => Color6_Element.Data; set => Color6_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color6_Element = new();
public UnityEngine.ColorX Color7 { get => Color7_Element.Data; set => Color7_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color7_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("EmitFromShell", EmitFromShell_Element.ToLinkField(context));
members.Add("DirectionMode", DirectionMode_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("DirectionTransformMode", DirectionTransformMode_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
members.Add("DirectionPostTransform", DirectionPostTransform_Element.ToLinkField(context));
members.Add("Color0", Color0_Element.ToLinkField(context));
members.Add("Color1", Color1_Element.ToLinkField(context));
members.Add("Color2", Color2_Element.ToLinkField(context));
members.Add("Color3", Color3_Element.ToLinkField(context));
members.Add("Color4", Color4_Element.ToLinkField(context));
members.Add("Color5", Color5_Element.ToLinkField(context));
members.Add("Color6", Color6_Element.ToLinkField(context));
members.Add("Color7", Color7_Element.ToLinkField(context));
}

}
}
