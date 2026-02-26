
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtofluxArrowManager
// Generated on: čtvrtek 26. února 2026 12:28:12
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtofluxArrowManager")]
public partial class ProtofluxArrowManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ConnectNode { get => ConnectNode_Element.Data; set => ConnectNode_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> ConnectNode_Element = new();
public global::FrooxEngine.IValue<UnityEngine.Vector3> TargetSize { get => TargetSize_Element.Data; set => TargetSize_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<UnityEngine.Vector3>>, global::FrooxEngine.IValue<UnityEngine.Vector3>> TargetSize_Element = new();
public global::FrooxEngine.IValue<UnityEngine.Vector3> TargetOffset { get => TargetOffset_Element.Data; set => TargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<UnityEngine.Vector3>>, global::FrooxEngine.IValue<UnityEngine.Vector3>> TargetOffset_Element = new();
public global::FrooxEngine.ArrowMesh _arrowMesh { get => _arrowMesh_Element.Data; set => _arrowMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ArrowMesh>, global::FrooxEngine.ArrowMesh> _arrowMesh_Element = new();
public global::FrooxEngine.MeshRenderer _renderer { get => _renderer_Element.Data; set => _renderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _renderer_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetVector { get => _targetVector_Element.Data; set => _targetVector_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _targetVector_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConnectNode", ConnectNode_Element.ToLinkReference(context));
members.Add("TargetSize", TargetSize_Element.ToLinkReference(context));
members.Add("TargetOffset", TargetOffset_Element.ToLinkReference(context));
members.Add("_arrowMesh", _arrowMesh_Element.ToLinkReference(context));
members.Add("_renderer", _renderer_Element.ToLinkReference(context));
members.Add("_targetVector", _targetVector_Element.ToLinkReference(context));
}

}
}
