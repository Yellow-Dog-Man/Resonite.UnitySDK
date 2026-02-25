
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevTool
// Generated on: středa 25. února 2026 16:14:19
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevTool")]
public partial class DevTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.DevTool.Selection SelectionMode;
public global::FrooxEngine.DevTool.Interaction InteractionMode;
public global::FrooxEngine.PointAnchor _selectedAnchor;
public global::FrooxEngine.Slot _selectedAnchorHighlight;
public global::FrooxEngine.OverlayFresnelMaterial _material;
public global::FrooxEngine.Slot _currentGizmo;
public global::FrooxEngine.Slot _previousGizmo;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectionMode", SelectionMode.ToResoniteLinkField());
members.Add("InteractionMode", InteractionMode.ToResoniteLinkField());
members.Add("_selectedAnchor", _selectedAnchor.ToResoniteReference(context));
members.Add("_selectedAnchorHighlight", _selectedAnchorHighlight.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_currentGizmo", _currentGizmo.ToResoniteReference(context));
members.Add("_previousGizmo", _previousGizmo.ToResoniteReference(context));
}

}
}
