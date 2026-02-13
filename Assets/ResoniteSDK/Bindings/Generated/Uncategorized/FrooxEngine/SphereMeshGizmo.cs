
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereMeshGizmo
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereMeshGizmo")]
public partial class SphereMeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.SphereMesh _target;
public global::FrooxEngine.SphereGizmo _sphereGizmo;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_sphereGizmo", new ResoniteLink.Reference() { });
}

}
}
