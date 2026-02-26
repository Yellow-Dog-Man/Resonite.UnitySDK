
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxReferenceProxy
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxReferenceProxy")]
public partial class ProtoFluxReferenceProxy : global::FrooxEngine.ProtoFlux.ProtoFluxRefProxy, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.ISyncRef NodeReference { get => NodeReference_Element.Data; set => NodeReference_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncRef>, global::FrooxEngine.ISyncRef> NodeReference_Element = new();
public global::FrooxEngine.ProtoFlux.ProtofluxArrowManager Arrow { get => Arrow_Element.Data; set => Arrow_Element.Data = value; }
public Field<global::FrooxEngine.CleanupRef<global::FrooxEngine.ProtoFlux.ProtofluxArrowManager>, global::FrooxEngine.ProtoFlux.ProtofluxArrowManager> Arrow_Element = new();
public global::FrooxEngine.Slot ConnectPoint { get => ConnectPoint_Element.Data; set => ConnectPoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ConnectPoint_Element = new();
public global::FrooxEngine.IValue<global::System.String> _currentName { get => _currentName_Element.Data; set => _currentName_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<global::System.String>>, global::FrooxEngine.IValue<global::System.String>> _currentName_Element = new();
public global::FrooxEngine.IValue<global::System.Boolean> _selfHovering { get => _selfHovering_Element.Data; set => _selfHovering_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<global::System.Boolean>>, global::FrooxEngine.IValue<global::System.Boolean>> _selfHovering_Element = new();
public global::FrooxEngine.IValue<global::System.Boolean> _targetHovering { get => _targetHovering_Element.Data; set => _targetHovering_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<global::System.Boolean>>, global::FrooxEngine.IValue<global::System.Boolean>> _targetHovering_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _arrowManagerEnabled { get => _arrowManagerEnabled_Element.Data; set => _arrowManagerEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _arrowManagerEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _arrowRendererEnabled { get => _arrowRendererEnabled_Element.Data; set => _arrowRendererEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _arrowRendererEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeReference", NodeReference_Element.ToLinkReference(context));
members.Add("Arrow", Arrow_Element.ToLinkReference(context));
members.Add("ConnectPoint", ConnectPoint_Element.ToLinkReference(context));
members.Add("_currentName", _currentName_Element.ToLinkReference(context));
members.Add("_selfHovering", _selfHovering_Element.ToLinkReference(context));
members.Add("_targetHovering", _targetHovering_Element.ToLinkReference(context));
members.Add("_arrowManagerEnabled", _arrowManagerEnabled_Element.ToLinkReference(context));
members.Add("_arrowRendererEnabled", _arrowRendererEnabled_Element.ToLinkReference(context));
}

}
}
