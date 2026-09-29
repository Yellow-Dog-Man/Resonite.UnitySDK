
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshGizmo
// Generated on: pátek 14. srpna 2026 21:58:02
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
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
public partial class MeshGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo, global::FrooxEngine.IGizmo

{
    public global::FrooxEngine.StaticMesh _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.StaticMesh>, global::FrooxEngine.StaticMesh> _target_Element = new();
public global::FrooxEngine.Slot _inspectorRoot { get => _inspectorRoot_Element.Data; set => _inspectorRoot_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _inspectorRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_inspectorRoot", _inspectorRoot_Element.ToLinkReference(context));
}

}
}
