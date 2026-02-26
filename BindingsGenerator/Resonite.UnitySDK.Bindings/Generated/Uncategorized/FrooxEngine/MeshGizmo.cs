
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshGizmo
// Generated on: čtvrtek 26. února 2026 12:28:12
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshGizmo")]
public partial class MeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.StaticMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.StaticMesh>, global::FrooxEngine.StaticMesh> _target_Element = new();
public global::FrooxEngine.Slot _inspectorRoot { get => _inspectorRoot_Element.Data; set => _inspectorRoot_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _inspectorRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_inspectorRoot", _inspectorRoot_Element.ToLinkReference(context));
}

}
}
