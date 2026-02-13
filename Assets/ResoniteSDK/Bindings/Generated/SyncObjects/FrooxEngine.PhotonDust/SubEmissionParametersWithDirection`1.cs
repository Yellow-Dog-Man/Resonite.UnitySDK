
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<>
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSystem", new ResoniteLink.Reference() { });
members.Add("InheritOrientation", InheritOrientation.ToResoniteLinkField());
members.Add("InheritScale", InheritScale.ToResoniteLinkField());
members.Add("InheritColor", InheritColor.ToResoniteLinkField());
members.Add("DirectionInheritance", DirectionInheritance.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
}

}
}
