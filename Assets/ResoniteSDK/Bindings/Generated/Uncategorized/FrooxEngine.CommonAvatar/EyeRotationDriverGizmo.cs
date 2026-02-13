
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriverGizmo
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_vectorGizmos", new ResoniteLink.SyncList()
{
    Elements = _vectorGizmos.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_coneGizmos", new ResoniteLink.SyncList()
{
    Elements = _coneGizmos.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
