
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeOverLifetimeStartEnd
// Generated on: pátek 13. února 2026 23:23:06
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeOverLifetimeStartEnd")]
public partial class SizeOverLifetimeStartEnd : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 StartSize;
public UnityEngine.Vector3 EndSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("StartSize", StartSize.ToResoniteLinkField());
members.Add("EndSize", EndSize.ToResoniteLinkField());
}

}
}
