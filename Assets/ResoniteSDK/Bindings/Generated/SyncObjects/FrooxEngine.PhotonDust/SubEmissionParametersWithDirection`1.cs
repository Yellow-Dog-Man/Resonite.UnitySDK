
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<>
// Generated on: úterý 24. února 2026 18:20:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<>")]
public partial class SubEmissionParametersWithDirection<P> : global::FrooxEngine.SyncObject
	where P : global::PhotonDust.SubEmissionParametersWithDirection

{
    public global::FrooxEngine.PhotonDust.ParticleSystem TargetSystem;
public global::System.Boolean InheritOrientation;
public global::System.Boolean InheritScale;
public global::System.Boolean InheritColor;
public global::PhotonDust.SubEmissionParametersWithDirection.DirectionInheritanceMode DirectionInheritance;
public UnityEngine.Vector3 Direction;
public global::System.Single RandomDirectionWeight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSystem", TargetSystem.ToResoniteReference(context));
members.Add("InheritOrientation", InheritOrientation.ToResoniteLinkField());
members.Add("InheritScale", InheritScale.ToResoniteLinkField());
members.Add("InheritColor", InheritColor.ToResoniteLinkField());
members.Add("DirectionInheritance", DirectionInheritance.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
}

}
}
