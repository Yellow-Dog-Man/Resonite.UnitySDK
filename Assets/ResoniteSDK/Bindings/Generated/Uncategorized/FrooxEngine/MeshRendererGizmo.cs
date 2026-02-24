
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererGizmo
// Generated on: úterý 24. února 2026 18:20:25
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererGizmo")]
public partial class MeshRendererGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IDevModeReceiver

{
    public global::FrooxEngine.MeshRenderer _target;
public global::FrooxEngine.MeshCollider _meshCollider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_meshCollider", _meshCollider.ToResoniteReference(context));
}

}
}
