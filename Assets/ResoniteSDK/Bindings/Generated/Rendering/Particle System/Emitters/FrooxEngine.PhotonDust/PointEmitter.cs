
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PointEmitter
// Generated on: pátek 13. února 2026 23:23:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PointEmitter")]
public partial class PointEmitter : global::FrooxEngine.PhotonDust.ParticleEmitter<global::System.Object>

{
    public UnityEngine.Vector3 Direction;
public global::System.Single RandomDirectionWeight;
public UnityEngine.ColorX Color;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
}

}
}
