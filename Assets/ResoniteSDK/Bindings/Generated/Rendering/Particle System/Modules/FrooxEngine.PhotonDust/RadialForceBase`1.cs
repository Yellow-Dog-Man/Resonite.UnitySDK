
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.RadialForceBase<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.RadialForceBase<>")]
public abstract partial class RadialForceBase<T> : global::FrooxEngine.PhotonDust.ParticleSystemModule<T>
	

{
    public global::System.Single Force;
public global::PhotonDust.RadialForceMode Mode;
public global::System.Single MinDistance;
public global::System.Single MaxDistance;
public global::System.Single MinForce;
public global::System.Single MaxForce;
public global::FrooxEngine.RootSpace OverrideForceSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Force", Force.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("MinForce", MinForce.ToResoniteLinkField());
members.Add("MaxForce", MaxForce.ToResoniteLinkField());
members.Add("OverrideForceSpace", new ResoniteLink.SyncObject() { Members = OverrideForceSpace.CollectMembers(context) });
}

}
}
