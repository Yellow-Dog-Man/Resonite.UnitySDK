
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SimplexTurbulentForce
// Generated on: pátek 13. února 2026 5:52:22
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SimplexTurbulentForce")]
public partial class SimplexTurbulentForce : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::PhotonDust.ForceMode Mode;
public global::System.Single Strength;
public global::System.Single GlobalNoiseOffset;
public UnityEngine.Vector3 Scale;
public UnityEngine.Vector3 Offset;
public global::System.Single X_NoiseOffset;
public global::System.Single Y_NoiseOffset;
public global::System.Single Z_NoiseOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Strength", Strength.ToResoniteLinkField());
members.Add("GlobalNoiseOffset", GlobalNoiseOffset.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("X_NoiseOffset", X_NoiseOffset.ToResoniteLinkField());
members.Add("Y_NoiseOffset", Y_NoiseOffset.ToResoniteLinkField());
members.Add("Z_NoiseOffset", Z_NoiseOffset.ToResoniteLinkField());
}

}
}
