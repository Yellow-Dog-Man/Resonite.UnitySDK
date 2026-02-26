
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriverGizmo
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriverGizmo")]
public partial class EyeRotationDriverGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.CommonAvatar.EyeRotationDriver _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.CommonAvatar.EyeRotationDriver>, global::FrooxEngine.CommonAvatar.EyeRotationDriver> _target_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.VectorGizmo>, global::FrooxEngine.VectorGizmo, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VectorGizmo>, global::FrooxEngine.VectorGizmo>> _vectorGizmos = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ConeGizmo>, global::FrooxEngine.ConeGizmo, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ConeGizmo>, global::FrooxEngine.ConeGizmo>> _coneGizmos = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_vectorGizmos", _vectorGizmos.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_coneGizmos", _coneGizmos.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
