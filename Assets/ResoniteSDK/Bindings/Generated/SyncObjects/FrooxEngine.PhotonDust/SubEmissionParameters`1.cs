
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParameters<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParameters<>")]
public partial class SubEmissionParameters<P> : global::FrooxEngine.SyncObject
	

{
    public global::FrooxEngine.PhotonDust.ParticleSystem TargetSystem;
public global::System.Boolean InheritOrientation;
public global::System.Boolean InheritScale;
public global::System.Boolean InheritColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSystem", TargetSystem.ToResoniteReference(context));
members.Add("InheritOrientation", InheritOrientation.ToResoniteLinkField());
members.Add("InheritScale", InheritScale.ToResoniteLinkField());
members.Add("InheritColor", InheritColor.ToResoniteLinkField());
}

}
}
