
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParameters<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParameters<>")]
public partial class SubEmissionParameters<P> : global::FrooxEngine.SyncObject
	

{
    public global::FrooxEngine.PhotonDust.ParticleSystem TargetSystem;
public global::System.Boolean InheritOrientation;
public global::System.Boolean InheritScale;
public global::System.Boolean InheritColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSystem", new ResoniteLink.Reference() { });
members.Add("InheritOrientation", InheritOrientation.ToResoniteLinkField());
members.Add("InheritScale", InheritScale.ToResoniteLinkField());
members.Add("InheritColor", InheritColor.ToResoniteLinkField());
}

}
}
