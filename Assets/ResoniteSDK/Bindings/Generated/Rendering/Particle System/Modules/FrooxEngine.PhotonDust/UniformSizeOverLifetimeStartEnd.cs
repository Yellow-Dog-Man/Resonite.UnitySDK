
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.UniformSizeOverLifetimeStartEnd
// Generated on: sobota 14. února 2026 8:58:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.UniformSizeOverLifetimeStartEnd")]
public partial class UniformSizeOverLifetimeStartEnd : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single StartSize;
public global::System.Single EndSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartSize", StartSize.ToResoniteLinkField());
members.Add("EndSize", EndSize.ToResoniteLinkField());
}

}
}
