
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection
// Generated on: čtvrtek 26. února 2026 10:04:38
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
members.Add("ReferenceDirection", ReferenceDirection_Element.Data.ToResoniteLinkField());
members.Add("AlignedColor", AlignedColor_Element.Data.ToResoniteLinkField());
members.Add("OrthogonalColor", OrthogonalColor_Element.Data.ToResoniteLinkField());
members.Add("OppositeColor", OppositeColor_Element.Data.ToResoniteLinkField());
}

}
}
