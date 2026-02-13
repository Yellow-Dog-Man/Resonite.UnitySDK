
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevTool
// Generated on: pátek 13. února 2026 23:23:07
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectionMode", SelectionMode.ToResoniteLinkField());
members.Add("InteractionMode", InteractionMode.ToResoniteLinkField());
members.Add("_selectedAnchor", new ResoniteLink.Reference() { });
members.Add("_selectedAnchorHighlight", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_currentGizmo", new ResoniteLink.Reference() { });
members.Add("_previousGizmo", new ResoniteLink.Reference() { });
}

}
}
