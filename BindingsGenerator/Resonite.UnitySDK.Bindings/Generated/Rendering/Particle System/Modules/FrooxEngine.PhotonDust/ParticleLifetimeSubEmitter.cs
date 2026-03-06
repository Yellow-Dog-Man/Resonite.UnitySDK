
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleLifetimeSubEmitter
// Generated on: pátek 6. března 2026 14:19:04
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleLifetimeSubEmitter")]
public partial class ParticleLifetimeSubEmitter : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single Rate { get => Rate_Element.Data; set => Rate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Rate_Element = new();
public global::FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<global::PhotonDust.SubEmissionParametersWithDirection> Parameters = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rate", Rate_Element.ToLinkField(context));
members.Add("Parameters", Parameters.ToLinkSyncObject(context));
}

}
}
