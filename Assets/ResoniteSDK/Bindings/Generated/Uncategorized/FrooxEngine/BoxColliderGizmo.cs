
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxColliderGizmo
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxColliderGizmo")]
public partial class BoxColliderGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.BoxCollider _target;
public global::FrooxEngine.BoxGizmo _cubeGizmo;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_cubeGizmo", new ResoniteLink.Reference() { });
}

}
}
