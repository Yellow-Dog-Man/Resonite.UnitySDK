
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReferenceEditor
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.Slot ReferenceRoot { get => ReferenceRoot_Element.Data; set => ReferenceRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ReferenceRoot_Element = new();
public global::FrooxEngine.Slot Item { get => Item_Element.Data; set => Item_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Item_Element = new();
public global::FrooxEngine.Slider Slider { get => Slider_Element.Data; set => Slider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slider>, global::FrooxEngine.Slider> Slider_Element = new();
public global::FrooxEngine.GripPoseReference PoseReference { get => PoseReference_Element.Data; set => PoseReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.GripPoseReference>, global::FrooxEngine.GripPoseReference> PoseReference_Element = new();
public global::System.Boolean HideVisualOnEnd { get => HideVisualOnEnd_Element.Data; set => HideVisualOnEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideVisualOnEnd_Element = new();
public UnityEngine.Vector3 RootPosition { get => RootPosition_Element.Data; set => RootPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RootPosition_Element = new();
public UnityEngine.Quaternion RootRotation { get => RootRotation_Element.Data; set => RootRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RootRotation_Element = new();
public UnityEngine.Vector3 RootScale { get => RootScale_Element.Data; set => RootScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RootScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceRoot", ReferenceRoot_Element.ToLinkReference(context));
members.Add("Item", Item_Element.ToLinkReference(context));
members.Add("Slider", Slider_Element.ToLinkReference(context));
members.Add("PoseReference", PoseReference_Element.ToLinkReference(context));
members.Add("HideVisualOnEnd", HideVisualOnEnd_Element.ToLinkField(context));
members.Add("RootPosition", RootPosition_Element.ToLinkField(context));
members.Add("RootRotation", RootRotation_Element.ToLinkField(context));
members.Add("RootScale", RootScale_Element.ToLinkField(context));
}

}
}
