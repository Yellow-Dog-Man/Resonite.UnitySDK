
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo
// Generated on: čtvrtek 26. února 2026 10:04:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> TargetRadius_Element = new();
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
members.Add("TargetRadius", TargetRadius_Element.Data.ToResoniteReference(context));
members.Add("RadiusSpace", new ResoniteLink.SyncObject() { Members = RadiusSpace.CollectMembers(context) });
members.Add("RimRadius", RimRadius_Element.Data.ToResoniteLinkField());
members.Add("RimRadiusDistanceScale", RimRadiusDistanceScale_Element.Data.ToResoniteLinkField());
members.Add("_handles", new ResoniteLink.SyncList()
{
    Elements = _handles.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
