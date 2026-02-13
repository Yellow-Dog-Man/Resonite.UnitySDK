
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeVisual
// Generated on: pátek 13. února 2026 23:23:08
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("IsSelected", IsSelected.ToResoniteLinkField());
members.Add("IsHighlighted", IsHighlighted.ToResoniteLinkField());
members.Add("_nodeHoverArea", new ResoniteLink.Reference() { });
members.Add("_bgImage", new ResoniteLink.Reference() { });
members.Add("_inputsRoot", new ResoniteLink.Reference() { });
members.Add("_outputsRoot", new ResoniteLink.Reference() { });
members.Add("_referencesRoot", new ResoniteLink.Reference() { });
members.Add("_overviewVisual", new ResoniteLink.Reference() { });
members.Add("_overviewBg", new ResoniteLink.Reference() { });
members.Add("_labelBg", new ResoniteLink.Reference() { });
members.Add("_labelText", new ResoniteLink.Reference() { });
}

}
}
