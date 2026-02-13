
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtofluxArrowManager
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ConnectNode", new ResoniteLink.Reference() { });
members.Add("TargetSize", new ResoniteLink.Reference() { });
members.Add("TargetOffset", new ResoniteLink.Reference() { });
members.Add("_arrowMesh", new ResoniteLink.Reference() { });
members.Add("_renderer", new ResoniteLink.Reference() { });
members.Add("_targetVector", new ResoniteLink.Reference() { });
}

}
}
