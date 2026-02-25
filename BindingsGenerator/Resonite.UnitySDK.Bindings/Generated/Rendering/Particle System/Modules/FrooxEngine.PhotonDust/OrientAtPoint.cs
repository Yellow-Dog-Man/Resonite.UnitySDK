
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.OrientAtPoint
// Generated on: středa 25. února 2026 16:14:18
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers(context) });
members.Add("TargetPoint", TargetPoint.ToResoniteLinkField());
members.Add("Up", Up.ToResoniteLinkField());
}

}
}
