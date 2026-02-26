
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevTool
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.DevTool.Selection SelectionMode { get => SelectionMode_Element.Data; set => SelectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.DevTool.Selection>, global::FrooxEngine.DevTool.Selection> SelectionMode_Element = new();
public global::FrooxEngine.DevTool.Interaction InteractionMode { get => InteractionMode_Element.Data; set => InteractionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.DevTool.Interaction>, global::FrooxEngine.DevTool.Interaction> InteractionMode_Element = new();
public global::FrooxEngine.PointAnchor _selectedAnchor { get => _selectedAnchor_Element.Data; set => _selectedAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PointAnchor>, global::FrooxEngine.PointAnchor> _selectedAnchor_Element = new();
public global::FrooxEngine.Slot _selectedAnchorHighlight { get => _selectedAnchorHighlight_Element.Data; set => _selectedAnchorHighlight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _selectedAnchorHighlight_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _material_Element = new();
public global::FrooxEngine.Slot _currentGizmo { get => _currentGizmo_Element.Data; set => _currentGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _currentGizmo_Element = new();
public global::FrooxEngine.Slot _previousGizmo { get => _previousGizmo_Element.Data; set => _previousGizmo_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _previousGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectionMode", SelectionMode_Element.ToLinkField(context));
members.Add("InteractionMode", InteractionMode_Element.ToLinkField(context));
members.Add("_selectedAnchor", _selectedAnchor_Element.ToLinkReference(context));
members.Add("_selectedAnchorHighlight", _selectedAnchorHighlight_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_currentGizmo", _currentGizmo_Element.ToLinkReference(context));
members.Add("_previousGizmo", _previousGizmo_Element.ToLinkReference(context));
}

}
}
