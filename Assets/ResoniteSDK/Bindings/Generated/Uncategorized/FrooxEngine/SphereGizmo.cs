
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo
// Generated on: sobota 14. února 2026 8:58:42
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereGizmo")]
public partial class SphereGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<global::System.Single> TargetRadius;
public global::FrooxEngine.RootSpace RadiusSpace;
public global::System.Single RimRadius;
public global::System.Single RimRadiusDistanceScale;
public System.Collections.Generic.List<global::FrooxEngine.SphereGizmo.Handle> _handles;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetRadius", TargetRadius.ToResoniteReference(context));
members.Add("RadiusSpace", new ResoniteLink.SyncObject() { Members = RadiusSpace.CollectMembers(context) });
members.Add("RimRadius", RimRadius.ToResoniteLinkField());
members.Add("RimRadiusDistanceScale", RimRadiusDistanceScale.ToResoniteLinkField());
members.Add("_handles", new ResoniteLink.SyncList()
{
    Elements = _handles.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
