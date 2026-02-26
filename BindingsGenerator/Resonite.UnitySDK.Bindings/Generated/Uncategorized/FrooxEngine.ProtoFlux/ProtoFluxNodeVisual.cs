
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeVisual
// Generated on: čtvrtek 26. února 2026 12:28:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeVisual")]
public partial class ProtoFluxNodeVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ProtoFlux.ProtoFluxNode>, global::FrooxEngine.ProtoFlux.ProtoFluxNode> Node_Element = new();
public global::System.Boolean IsSelected { get => IsSelected_Element.Data; set => IsSelected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSelected_Element = new();
public global::System.Boolean IsHighlighted { get => IsHighlighted_Element.Data; set => IsHighlighted_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHighlighted_Element = new();
public global::FrooxEngine.UIX.HoverArea _nodeHoverArea { get => _nodeHoverArea_Element.Data; set => _nodeHoverArea_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.HoverArea>, global::FrooxEngine.UIX.HoverArea> _nodeHoverArea_Element = new();
public global::FrooxEngine.UIX.Image _bgImage { get => _bgImage_Element.Data; set => _bgImage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Image>, global::FrooxEngine.UIX.Image> _bgImage_Element = new();
public global::FrooxEngine.Slot _inputsRoot { get => _inputsRoot_Element.Data; set => _inputsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _inputsRoot_Element = new();
public global::FrooxEngine.Slot _outputsRoot { get => _outputsRoot_Element.Data; set => _outputsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _outputsRoot_Element = new();
public global::FrooxEngine.Slot _referencesRoot { get => _referencesRoot_Element.Data; set => _referencesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _referencesRoot_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _overviewVisual { get => _overviewVisual_Element.Data; set => _overviewVisual_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _overviewVisual_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _overviewBg { get => _overviewBg_Element.Data; set => _overviewBg_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _overviewBg_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _labelBg { get => _labelBg_Element.Data; set => _labelBg_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _labelBg_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _labelText { get => _labelText_Element.Data; set => _labelText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _labelText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkReference(context));
members.Add("IsSelected", IsSelected_Element.ToLinkField(context));
members.Add("IsHighlighted", IsHighlighted_Element.ToLinkField(context));
members.Add("_nodeHoverArea", _nodeHoverArea_Element.ToLinkReference(context));
members.Add("_bgImage", _bgImage_Element.ToLinkReference(context));
members.Add("_inputsRoot", _inputsRoot_Element.ToLinkReference(context));
members.Add("_outputsRoot", _outputsRoot_Element.ToLinkReference(context));
members.Add("_referencesRoot", _referencesRoot_Element.ToLinkReference(context));
members.Add("_overviewVisual", _overviewVisual_Element.ToLinkReference(context));
members.Add("_overviewBg", _overviewBg_Element.ToLinkReference(context));
members.Add("_labelBg", _labelBg_Element.ToLinkReference(context));
members.Add("_labelText", _labelText_Element.ToLinkReference(context));
}

}
}
