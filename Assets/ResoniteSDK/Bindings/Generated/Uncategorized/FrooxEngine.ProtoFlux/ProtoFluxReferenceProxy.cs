
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxReferenceProxy
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeReference", NodeReference.ToResoniteReference(context));
members.Add("Arrow", Arrow.ToResoniteReference(context));
members.Add("ConnectPoint", ConnectPoint.ToResoniteReference(context));
members.Add("_currentName", _currentName.ToResoniteReference(context));
members.Add("_selfHovering", _selfHovering.ToResoniteReference(context));
members.Add("_targetHovering", _targetHovering.ToResoniteReference(context));
members.Add("_arrowManagerEnabled", _arrowManagerEnabled.ToResoniteReference(context));
members.Add("_arrowRendererEnabled", _arrowRendererEnabled.ToResoniteReference(context));
}

}
}
