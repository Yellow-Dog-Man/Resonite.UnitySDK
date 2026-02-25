
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection")]
public partial class ColorByOrientationDirection : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 ReferenceDirection;
public UnityEngine.ColorX AlignedColor;
public UnityEngine.ColorX OrthogonalColor;
public UnityEngine.ColorX OppositeColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceDirection", ReferenceDirection.ToResoniteLinkField());
members.Add("AlignedColor", AlignedColor.ToResoniteLinkField());
members.Add("OrthogonalColor", OrthogonalColor.ToResoniteLinkField());
members.Add("OppositeColor", OppositeColor.ToResoniteLinkField());
}

}
}
