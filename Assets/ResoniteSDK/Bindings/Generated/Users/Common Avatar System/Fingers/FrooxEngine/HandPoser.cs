
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser
// Generated on: pátek 13. února 2026 5:52:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HandPoser")]
public partial class HandPoser : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IFingerPoseSourceComponent PoseSource;
public global::Renderite.Shared.Chirality Side;
public global::System.Boolean PoseMetacarpals;
public global::FrooxEngine.Slot HandRoot;
public UnityEngine.Vector3 HandForward;
public UnityEngine.Vector3 HandUp;
public UnityEngine.Vector3 HandRight;
public global::FrooxEngine.HandPoser.Finger Thumb;
public global::FrooxEngine.HandPoser.Finger Index;
public global::FrooxEngine.HandPoser.Finger Middle;
public global::FrooxEngine.HandPoser.Finger Ring;
public global::FrooxEngine.HandPoser.Finger Pinky;
public global::System.Boolean DebugFingers;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PoseSource", new ResoniteLink.Reference() { });
members.Add("Side", Side.ToResoniteLinkField());
members.Add("PoseMetacarpals", PoseMetacarpals.ToResoniteLinkField());
members.Add("HandRoot", new ResoniteLink.Reference() { });
members.Add("HandForward", HandForward.ToResoniteLinkField());
members.Add("HandUp", HandUp.ToResoniteLinkField());
members.Add("HandRight", HandRight.ToResoniteLinkField());
members.Add("Thumb", new ResoniteLink.SyncObject() { Members = Thumb.CollectMembers() });
members.Add("Index", new ResoniteLink.SyncObject() { Members = Index.CollectMembers() });
members.Add("Middle", new ResoniteLink.SyncObject() { Members = Middle.CollectMembers() });
members.Add("Ring", new ResoniteLink.SyncObject() { Members = Ring.CollectMembers() });
members.Add("Pinky", new ResoniteLink.SyncObject() { Members = Pinky.CollectMembers() });
members.Add("DebugFingers", DebugFingers.ToResoniteLinkField());
}

}
}
