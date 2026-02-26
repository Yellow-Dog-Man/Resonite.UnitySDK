
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.OrientAtPoint
// Generated on: čtvrtek 26. února 2026 12:28:04
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.RootSpace PointSpace = new();
public UnityEngine.Vector3 TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPoint_Element = new();
public UnityEngine.Vector3 Up { get => Up_Element.Data; set => Up_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Up_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", PointSpace.ToLinkSyncObject(context));
members.Add("TargetPoint", TargetPoint_Element.ToLinkField(context));
members.Add("Up", Up_Element.ToLinkField(context));
}

}
}
