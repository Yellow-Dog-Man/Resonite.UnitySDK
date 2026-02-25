
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Gizmo
// Generated on: středa 25. února 2026 16:14:35
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
    public global::FrooxEngine.Slot TargetSlot;
public global::System.Boolean AutoPositionAtTargetSlot;
public global::FrooxEngine.Component _interactingComponent;
public global::FrooxEngine.OverlayFresnelMaterial _material;
public global::FrooxEngine.Slot _toolPoint;
public global::FrooxEngine.Slot _activePoint;
public global::FrooxEngine.Slot _lineRoot;
public global::FrooxEngine.SegmentMesh _lineSegment;
public global::FrooxEngine.Slot _snapHighlight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
members.Add("AutoPositionAtTargetSlot", AutoPositionAtTargetSlot.ToResoniteLinkField());
members.Add("_interactingComponent", _interactingComponent.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_toolPoint", _toolPoint.ToResoniteReference(context));
members.Add("_activePoint", _activePoint.ToResoniteReference(context));
members.Add("_lineRoot", _lineRoot.ToResoniteReference(context));
members.Add("_lineSegment", _lineSegment.ToResoniteReference(context));
members.Add("_snapHighlight", _snapHighlight.ToResoniteReference(context));
}

}
}
