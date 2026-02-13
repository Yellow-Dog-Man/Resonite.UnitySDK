
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxReferenceProxy
// Generated on: pátek 13. února 2026 23:23:17
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxReferenceProxy")]
public partial class ProtoFluxReferenceProxy : global::FrooxEngine.ProtoFlux.ProtoFluxRefProxy, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.ISyncRef NodeReference;
public global::FrooxEngine.ProtoFlux.ProtofluxArrowManager Arrow;
public global::FrooxEngine.Slot ConnectPoint;
public global::FrooxEngine.IValue<global::System.String> _currentName;
public global::FrooxEngine.IValue<global::System.Boolean> _selfHovering;
public global::FrooxEngine.IValue<global::System.Boolean> _targetHovering;
public global::FrooxEngine.IField<global::System.Boolean> _arrowManagerEnabled;
public global::FrooxEngine.IField<global::System.Boolean> _arrowRendererEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NodeReference", new ResoniteLink.Reference() { });
members.Add("Arrow", new ResoniteLink.Reference() { });
members.Add("ConnectPoint", new ResoniteLink.Reference() { });
members.Add("_currentName", new ResoniteLink.Reference() { });
members.Add("_selfHovering", new ResoniteLink.Reference() { });
members.Add("_targetHovering", new ResoniteLink.Reference() { });
members.Add("_arrowManagerEnabled", new ResoniteLink.Reference() { });
members.Add("_arrowRendererEnabled", new ResoniteLink.Reference() { });
}

}
}
