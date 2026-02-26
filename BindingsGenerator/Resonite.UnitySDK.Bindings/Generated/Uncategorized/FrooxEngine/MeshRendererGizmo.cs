
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererGizmo
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererGizmo")]
public partial class MeshRendererGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IDevModeReceiver

{
    public global::FrooxEngine.MeshRenderer _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _target_Element = new();
public global::FrooxEngine.MeshCollider _meshCollider { get => _meshCollider_Element.Data; set => _meshCollider_Element.Data = value; }
public Reference<global::FrooxEngine.CleanupRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _meshCollider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_meshCollider", _meshCollider_Element.ToLinkReference(context));
}

}
}
