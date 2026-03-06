
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection
// Generated on: pátek 6. března 2026 14:19:04
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection")]
public partial class ColorByOrientationDirection : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 ReferenceDirection { get => ReferenceDirection_Element.Data; set => ReferenceDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ReferenceDirection_Element = new();
public UnityEngine.ColorX AlignedColor { get => AlignedColor_Element.Data; set => AlignedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlignedColor_Element = new();
public UnityEngine.ColorX OrthogonalColor { get => OrthogonalColor_Element.Data; set => OrthogonalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OrthogonalColor_Element = new();
public UnityEngine.ColorX OppositeColor { get => OppositeColor_Element.Data; set => OppositeColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OppositeColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceDirection", ReferenceDirection_Element.ToLinkField(context));
members.Add("AlignedColor", AlignedColor_Element.ToLinkField(context));
members.Add("OrthogonalColor", OrthogonalColor_Element.ToLinkField(context));
members.Add("OppositeColor", OppositeColor_Element.ToLinkField(context));
}

}
}
