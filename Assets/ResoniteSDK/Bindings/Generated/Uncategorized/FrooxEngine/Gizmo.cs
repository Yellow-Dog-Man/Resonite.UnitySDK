
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Gizmo
// Generated on: pátek 13. února 2026 23:23:12
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSlot", new ResoniteLink.Reference() { });
members.Add("AutoPositionAtTargetSlot", AutoPositionAtTargetSlot.ToResoniteLinkField());
members.Add("_interactingComponent", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_toolPoint", new ResoniteLink.Reference() { });
members.Add("_activePoint", new ResoniteLink.Reference() { });
members.Add("_lineRoot", new ResoniteLink.Reference() { });
members.Add("_lineSegment", new ResoniteLink.Reference() { });
members.Add("_snapHighlight", new ResoniteLink.Reference() { });
}

}
}
