
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReferenceEditor
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GripPoseReferenceEditor")]
public partial class GripPoseReferenceEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ReferenceRoot;
public global::FrooxEngine.Slot Item;
public global::FrooxEngine.Slider Slider;
public global::FrooxEngine.GripPoseReference PoseReference;
public global::System.Boolean HideVisualOnEnd;
public UnityEngine.Vector3 RootPosition;
public UnityEngine.Quaternion RootRotation;
public UnityEngine.Vector3 RootScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceRoot", ReferenceRoot.ToResoniteReference(context));
members.Add("Item", Item.ToResoniteReference(context));
members.Add("Slider", Slider.ToResoniteReference(context));
members.Add("PoseReference", PoseReference.ToResoniteReference(context));
members.Add("HideVisualOnEnd", HideVisualOnEnd.ToResoniteLinkField());
members.Add("RootPosition", RootPosition.ToResoniteLinkField());
members.Add("RootRotation", RootRotation.ToResoniteLinkField());
members.Add("RootScale", RootScale.ToResoniteLinkField());
}

}
}
