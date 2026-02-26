
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SimplexTurbulentForce
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SimplexTurbulentForce")]
public partial class SimplexTurbulentForce : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::PhotonDust.ForceMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ForceMode>, global::PhotonDust.ForceMode> Mode_Element = new();
public global::System.Single Strength { get => Strength_Element.Data; set => Strength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Strength_Element = new();
public global::System.Single GlobalNoiseOffset { get => GlobalNoiseOffset_Element.Data; set => GlobalNoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GlobalNoiseOffset_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::System.Single X_NoiseOffset { get => X_NoiseOffset_Element.Data; set => X_NoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> X_NoiseOffset_Element = new();
public global::System.Single Y_NoiseOffset { get => Y_NoiseOffset_Element.Data; set => Y_NoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Y_NoiseOffset_Element = new();
public global::System.Single Z_NoiseOffset { get => Z_NoiseOffset_Element.Data; set => Z_NoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Z_NoiseOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("Strength", Strength_Element.ToLinkField(context));
members.Add("GlobalNoiseOffset", GlobalNoiseOffset_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("X_NoiseOffset", X_NoiseOffset_Element.ToLinkField(context));
members.Add("Y_NoiseOffset", Y_NoiseOffset_Element.ToLinkField(context));
members.Add("Z_NoiseOffset", Z_NoiseOffset_Element.ToLinkField(context));
}

}
}
