
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection
// Generated on: pátek 13. února 2026 23:23:05
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorByOrientationDirection")]
public partial class ColorByOrientationDirection : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 ReferenceDirection;
public UnityEngine.ColorX AlignedColor;
public UnityEngine.ColorX OrthogonalColor;
public UnityEngine.ColorX OppositeColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceDirection", ReferenceDirection.ToResoniteLinkField());
members.Add("AlignedColor", AlignedColor.ToResoniteLinkField());
members.Add("OrthogonalColor", OrthogonalColor.ToResoniteLinkField());
members.Add("OppositeColor", OppositeColor.ToResoniteLinkField());
}

}
}
