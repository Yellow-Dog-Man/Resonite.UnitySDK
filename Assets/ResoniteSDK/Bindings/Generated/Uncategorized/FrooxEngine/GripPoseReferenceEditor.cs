
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReferenceEditor
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceRoot", new ResoniteLink.Reference() { });
members.Add("Item", new ResoniteLink.Reference() { });
members.Add("Slider", new ResoniteLink.Reference() { });
members.Add("PoseReference", new ResoniteLink.Reference() { });
members.Add("HideVisualOnEnd", HideVisualOnEnd.ToResoniteLinkField());
members.Add("RootPosition", RootPosition.ToResoniteLinkField());
members.Add("RootRotation", RootRotation.ToResoniteLinkField());
members.Add("RootScale", RootScale.ToResoniteLinkField());
}

}
}
