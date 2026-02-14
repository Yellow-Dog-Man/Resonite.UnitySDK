
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.OrientByVelocity
// Generated on: sobota 14. února 2026 8:58:35
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.OrientByVelocity")]
public partial class OrientByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 Up;
public global::System.Single MinimumVelocity;
public global::System.Single VelocityTransitionRange;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Up", Up.ToResoniteLinkField());
members.Add("MinimumVelocity", MinimumVelocity.ToResoniteLinkField());
members.Add("VelocityTransitionRange", VelocityTransitionRange.ToResoniteLinkField());
}

}
}
