
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleGizmo
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleGizmo")]
public partial class ScaleGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> TargetScale;
public global::System.Single HandleLength;
public global::FrooxEngine.Slot _xSlot;
public global::FrooxEngine.Slot _ySlot;
public global::FrooxEngine.Slot _zSlot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetScale", TargetScale.ToResoniteReference(context));
members.Add("HandleLength", HandleLength.ToResoniteLinkField());
members.Add("_xSlot", _xSlot.ToResoniteReference(context));
members.Add("_ySlot", _ySlot.ToResoniteReference(context));
members.Add("_zSlot", _zSlot.ToResoniteReference(context));
}

}
}
