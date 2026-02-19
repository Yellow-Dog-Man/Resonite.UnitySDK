
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeSineMultiplier
// Generated on: čtvrtek 19. února 2026 8:00:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeSineMultiplier")]
public partial class SizeSineMultiplier : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 Speed;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 MinMultiplier;
public UnityEngine.Vector3 MaxMultiplier;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("MinMultiplier", MinMultiplier.ToResoniteLinkField());
members.Add("MaxMultiplier", MaxMultiplier.ToResoniteLinkField());
}

}
}
