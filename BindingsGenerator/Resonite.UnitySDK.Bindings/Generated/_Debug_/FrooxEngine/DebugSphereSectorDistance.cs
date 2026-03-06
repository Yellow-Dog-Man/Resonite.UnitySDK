
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSphereSectorDistance
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSphereSectorDistance")]
public partial class DebugSphereSectorDistance : global::FrooxEngine.Component

{
    public global::System.Single Angle { get => Angle_Element.Data; set => Angle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Angle_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<UnityEngine.Vector3>, UnityEngine.Vector3, Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3>> Points = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Angle", Angle_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Points", Points.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
