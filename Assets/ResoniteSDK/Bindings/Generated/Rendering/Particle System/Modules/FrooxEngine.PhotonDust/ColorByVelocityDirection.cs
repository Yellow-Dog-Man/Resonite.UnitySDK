
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByVelocityDirection
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByVelocityDirection")]
public partial class ColorByVelocityDirection : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

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
