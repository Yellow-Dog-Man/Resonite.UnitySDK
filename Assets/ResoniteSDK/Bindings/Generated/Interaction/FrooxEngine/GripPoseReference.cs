
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReference
// Generated on: čtvrtek 19. února 2026 7:58:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GripPoseReference")]
public partial class GripPoseReference : global::FrooxEngine.Component

{
    public global::Renderite.Shared.Chirality HandSide;
public UnityEngine.Vector3 _rootPos;
public global::FrooxEngine.Slot TipReference;
public global::System.Boolean ShowVisual;
public global::System.Boolean DisableSlider;
public global::FrooxEngine.Slot _activeVisual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HandSide", HandSide.ToResoniteLinkField());
members.Add("_rootPos", _rootPos.ToResoniteLinkField());
members.Add("TipReference", TipReference.ToResoniteReference(context));
members.Add("ShowVisual", ShowVisual.ToResoniteLinkField());
members.Add("DisableSlider", DisableSlider.ToResoniteLinkField());
members.Add("_activeVisual", _activeVisual.ToResoniteReference(context));
}

}
}
