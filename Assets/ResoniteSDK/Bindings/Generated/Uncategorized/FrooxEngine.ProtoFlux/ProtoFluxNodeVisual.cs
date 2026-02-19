
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeVisual
// Generated on: čtvrtek 19. února 2026 8:00:22
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeVisual")]
public partial class ProtoFluxNodeVisual : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node;
public global::System.Boolean IsSelected;
public global::System.Boolean IsHighlighted;
public global::FrooxEngine.UIX.HoverArea _nodeHoverArea;
public global::FrooxEngine.UIX.Image _bgImage;
public global::FrooxEngine.Slot _inputsRoot;
public global::FrooxEngine.Slot _outputsRoot;
public global::FrooxEngine.Slot _referencesRoot;
public global::FrooxEngine.IField<global::System.Boolean> _overviewVisual;
public global::FrooxEngine.IField<UnityEngine.ColorX> _overviewBg;
public global::FrooxEngine.IField<global::System.Boolean> _labelBg;
public global::FrooxEngine.IField<global::System.Boolean> _labelText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteReference(context));
members.Add("IsSelected", IsSelected.ToResoniteLinkField());
members.Add("IsHighlighted", IsHighlighted.ToResoniteLinkField());
members.Add("_nodeHoverArea", _nodeHoverArea.ToResoniteReference(context));
members.Add("_bgImage", _bgImage.ToResoniteReference(context));
members.Add("_inputsRoot", _inputsRoot.ToResoniteReference(context));
members.Add("_outputsRoot", _outputsRoot.ToResoniteReference(context));
members.Add("_referencesRoot", _referencesRoot.ToResoniteReference(context));
members.Add("_overviewVisual", _overviewVisual.ToResoniteReference(context));
members.Add("_overviewBg", _overviewBg.ToResoniteReference(context));
members.Add("_labelBg", _labelBg.ToResoniteReference(context));
members.Add("_labelText", _labelText.ToResoniteReference(context));
}

}
}
