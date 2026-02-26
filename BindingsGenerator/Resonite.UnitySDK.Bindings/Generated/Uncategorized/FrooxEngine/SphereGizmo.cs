
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<global::System.Single> TargetRadius { get => TargetRadius_Element.Data; set => TargetRadius_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetRadius_Element = new();
public global::FrooxEngine.RootSpace RadiusSpace = new();
public global::System.Single RimRadius { get => RimRadius_Element.Data; set => RimRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimRadius_Element = new();
public global::System.Single RimRadiusDistanceScale { get => RimRadiusDistanceScale_Element.Data; set => RimRadiusDistanceScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimRadiusDistanceScale_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.SphereGizmo.Handle>, global::FrooxEngine.SphereGizmo.Handle> _handles = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetRadius", TargetRadius_Element.ToLinkReference(context));
members.Add("RadiusSpace", RadiusSpace.ToLinkSyncObject(context));
members.Add("RimRadius", RimRadius_Element.ToLinkField(context));
members.Add("RimRadiusDistanceScale", RimRadiusDistanceScale_Element.ToLinkField(context));
members.Add("_handles", _handles.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
