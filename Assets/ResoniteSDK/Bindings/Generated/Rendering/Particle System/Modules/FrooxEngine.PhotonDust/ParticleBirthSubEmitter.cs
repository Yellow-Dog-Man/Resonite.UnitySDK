
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleBirthSubEmitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleBirthSubEmitter")]
public partial class ParticleBirthSubEmitter : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Int32 EmitMin;
public global::System.Int32 EmitMax;
public global::FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<global::PhotonDust.SubEmissionParametersWithDirection> Parameters;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("EmitMin", EmitMin.ToResoniteLinkField());
members.Add("EmitMax", EmitMax.ToResoniteLinkField());
members.Add("Parameters", new ResoniteLink.SyncObject() { Members = Parameters.CollectMembers() });
}

}
}
