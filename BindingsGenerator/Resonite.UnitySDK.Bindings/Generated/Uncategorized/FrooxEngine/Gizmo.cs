
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Gizmo
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Gizmo")]
public abstract partial class Gizmo : global::FrooxEngine.Component, global::FrooxEngine.IMaterialApplyPolicy

{
    public global::FrooxEngine.Slot TargetSlot { get => TargetSlot_Element.Data; set => TargetSlot_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> TargetSlot_Element = new();
public global::System.Boolean AutoPositionAtTargetSlot { get => AutoPositionAtTargetSlot_Element.Data; set => AutoPositionAtTargetSlot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoPositionAtTargetSlot_Element = new();
public global::FrooxEngine.Component _interactingComponent { get => _interactingComponent_Element.Data; set => _interactingComponent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Component>, global::FrooxEngine.Component> _interactingComponent_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _material_Element = new();
public global::FrooxEngine.Slot _toolPoint { get => _toolPoint_Element.Data; set => _toolPoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _toolPoint_Element = new();
public global::FrooxEngine.Slot _activePoint { get => _activePoint_Element.Data; set => _activePoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _activePoint_Element = new();
public global::FrooxEngine.Slot _lineRoot { get => _lineRoot_Element.Data; set => _lineRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _lineRoot_Element = new();
public global::FrooxEngine.SegmentMesh _lineSegment { get => _lineSegment_Element.Data; set => _lineSegment_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SegmentMesh>, global::FrooxEngine.SegmentMesh> _lineSegment_Element = new();
public global::FrooxEngine.Slot _snapHighlight { get => _snapHighlight_Element.Data; set => _snapHighlight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _snapHighlight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot_Element.Data.ToResoniteReference(context));
members.Add("AutoPositionAtTargetSlot", AutoPositionAtTargetSlot_Element.Data.ToResoniteLinkField());
members.Add("_interactingComponent", _interactingComponent_Element.Data.ToResoniteReference(context));
members.Add("_material", _material_Element.Data.ToResoniteReference(context));
members.Add("_toolPoint", _toolPoint_Element.Data.ToResoniteReference(context));
members.Add("_activePoint", _activePoint_Element.Data.ToResoniteReference(context));
members.Add("_lineRoot", _lineRoot_Element.Data.ToResoniteReference(context));
members.Add("_lineSegment", _lineSegment_Element.Data.ToResoniteReference(context));
members.Add("_snapHighlight", _snapHighlight_Element.Data.ToResoniteReference(context));
}

}
}
