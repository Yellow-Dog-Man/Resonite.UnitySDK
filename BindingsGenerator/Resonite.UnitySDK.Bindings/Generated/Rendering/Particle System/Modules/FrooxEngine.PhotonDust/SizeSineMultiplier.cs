
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeSineMultiplier
// Generated on: středa 25. února 2026 16:14:18
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
