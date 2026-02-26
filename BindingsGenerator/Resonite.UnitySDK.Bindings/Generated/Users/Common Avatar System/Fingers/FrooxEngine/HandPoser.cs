
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HandPoser")]
public partial class HandPoser : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IFingerPoseSourceComponent PoseSource { get => PoseSource_Element.Data; set => PoseSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> PoseSource_Element = new();
public global::Renderite.Shared.Chirality Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Side_Element = new();
public global::System.Boolean PoseMetacarpals { get => PoseMetacarpals_Element.Data; set => PoseMetacarpals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PoseMetacarpals_Element = new();
public global::FrooxEngine.Slot HandRoot { get => HandRoot_Element.Data; set => HandRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> HandRoot_Element = new();
public UnityEngine.Vector3 HandForward { get => HandForward_Element.Data; set => HandForward_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandForward_Element = new();
public UnityEngine.Vector3 HandUp { get => HandUp_Element.Data; set => HandUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandUp_Element = new();
public UnityEngine.Vector3 HandRight { get => HandRight_Element.Data; set => HandRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandRight_Element = new();
public global::FrooxEngine.HandPoser.Finger Thumb = new();
public global::FrooxEngine.HandPoser.Finger Index = new();
public global::FrooxEngine.HandPoser.Finger Middle = new();
public global::FrooxEngine.HandPoser.Finger Ring = new();
public global::FrooxEngine.HandPoser.Finger Pinky = new();
public global::System.Boolean DebugFingers { get => DebugFingers_Element.Data; set => DebugFingers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DebugFingers_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PoseSource", PoseSource_Element.Data.ToResoniteReference(context));
members.Add("Side", Side_Element.Data.ToResoniteLinkField());
members.Add("PoseMetacarpals", PoseMetacarpals_Element.Data.ToResoniteLinkField());
members.Add("HandRoot", HandRoot_Element.Data.ToResoniteReference(context));
members.Add("HandForward", HandForward_Element.Data.ToResoniteLinkField());
members.Add("HandUp", HandUp_Element.Data.ToResoniteLinkField());
members.Add("HandRight", HandRight_Element.Data.ToResoniteLinkField());
members.Add("Thumb", new ResoniteLink.SyncObject() { Members = Thumb.CollectMembers(context) });
members.Add("Index", new ResoniteLink.SyncObject() { Members = Index.CollectMembers(context) });
members.Add("Middle", new ResoniteLink.SyncObject() { Members = Middle.CollectMembers(context) });
members.Add("Ring", new ResoniteLink.SyncObject() { Members = Ring.CollectMembers(context) });
members.Add("Pinky", new ResoniteLink.SyncObject() { Members = Pinky.CollectMembers(context) });
members.Add("DebugFingers", DebugFingers_Element.Data.ToResoniteLinkField());
}

}
}
