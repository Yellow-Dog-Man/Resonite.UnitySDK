
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtofluxArrowManager
// Generated on: sobota 14. února 2026 8:58:46
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.Slot ConnectNode;
public global::FrooxEngine.IValue<UnityEngine.Vector3> TargetSize;
public global::FrooxEngine.IValue<UnityEngine.Vector3> TargetOffset;
public global::FrooxEngine.ArrowMesh _arrowMesh;
public global::FrooxEngine.MeshRenderer _renderer;
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetVector;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConnectNode", ConnectNode.ToResoniteReference(context));
members.Add("TargetSize", TargetSize.ToResoniteReference(context));
members.Add("TargetOffset", TargetOffset.ToResoniteReference(context));
members.Add("_arrowMesh", _arrowMesh.ToResoniteReference(context));
members.Add("_renderer", _renderer.ToResoniteReference(context));
members.Add("_targetVector", _targetVector.ToResoniteReference(context));
}

}
}
