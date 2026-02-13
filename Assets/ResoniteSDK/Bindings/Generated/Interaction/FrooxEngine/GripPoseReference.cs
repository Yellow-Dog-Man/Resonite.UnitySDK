
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReference
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GripPoseReference")]
public partial class GripPoseReference : global::FrooxEngine.Component

{
    public global::Renderite.Shared.Chirality HandSide;
public UnityEngine.Vector3 _rootPos;
public global::FrooxEngine.Slot TipReference;
public global::System.Boolean ShowVisual;
public global::System.Boolean DisableSlider;
public global::FrooxEngine.Slot _activeVisual;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HandSide", HandSide.ToResoniteLinkField());
members.Add("_rootPos", _rootPos.ToResoniteLinkField());
members.Add("TipReference", new ResoniteLink.Reference() { });
members.Add("ShowVisual", ShowVisual.ToResoniteLinkField());
members.Add("DisableSlider", DisableSlider.ToResoniteLinkField());
members.Add("_activeVisual", new ResoniteLink.Reference() { });
}

}
}
