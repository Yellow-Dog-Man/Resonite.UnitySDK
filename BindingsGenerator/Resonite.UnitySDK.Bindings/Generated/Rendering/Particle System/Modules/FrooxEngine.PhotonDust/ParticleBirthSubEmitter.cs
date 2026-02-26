
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleBirthSubEmitter
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Int32 EmitMin { get => EmitMin_Element.Data; set => EmitMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EmitMin_Element = new();
public global::System.Int32 EmitMax { get => EmitMax_Element.Data; set => EmitMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EmitMax_Element = new();
public global::FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<global::PhotonDust.SubEmissionParametersWithDirection> Parameters = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EmitMin", EmitMin_Element.ToLinkField(context));
members.Add("EmitMax", EmitMax_Element.ToLinkField(context));
members.Add("Parameters", Parameters.ToLinkSyncObject(context));
}

}
}
