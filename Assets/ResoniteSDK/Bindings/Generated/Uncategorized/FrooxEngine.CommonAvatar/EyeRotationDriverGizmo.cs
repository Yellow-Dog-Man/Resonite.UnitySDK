
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriverGizmo
// Generated on: úterý 24. února 2026 18:20:21
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.CommonAvatar.EyeRotationDriver _target;
public System.Collections.Generic.List<global::FrooxEngine.VectorGizmo> _vectorGizmos;
public System.Collections.Generic.List<global::FrooxEngine.ConeGizmo> _coneGizmos;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_vectorGizmos", new ResoniteLink.SyncList()
{
    Elements = _vectorGizmos.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_coneGizmos", new ResoniteLink.SyncList()
{
    Elements = _coneGizmos.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
