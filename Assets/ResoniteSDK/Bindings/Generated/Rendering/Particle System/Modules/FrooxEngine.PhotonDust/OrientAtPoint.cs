
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.OrientAtPoint
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.OrientAtPoint")]
public partial class OrientAtPoint : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::FrooxEngine.RootSpace PointSpace;
public UnityEngine.Vector3 TargetPoint;
public UnityEngine.Vector3 Up;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers() });
members.Add("TargetPoint", TargetPoint.ToResoniteLinkField());
members.Add("Up", Up.ToResoniteLinkField());
}

}
}
