
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeModifier
// Generated on: úterý 24. února 2026 18:20:09
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeModifier")]
public partial class SizeModifier : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 Multiplier;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 SizeClampMin;
public UnityEngine.Vector3 SizeClampMax;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Multiplier", Multiplier.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("SizeClampMin", SizeClampMin.ToResoniteLinkField());
members.Add("SizeClampMax", SizeClampMax.ToResoniteLinkField());
}

}
}
