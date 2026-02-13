
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKDraggableOffset
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKDraggableOffset")]
public partial class IKDraggableOffset : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::FrooxEngine.FinalIK.IKSolver Solver;
public global::FrooxEngine.Sync<UnityEngine.Vector3> PositionTarget;
public global::FrooxEngine.Sync<UnityEngine.Quaternion> RotationTarget;
public global::FrooxEngine.Sync<global::System.Single> Weight;
public global::FrooxEngine.Grabber _grabber;
public global::FrooxEngine.User _grabbingUser;
public global::FrooxEngine.Slot _holdSlot;
public UnityEngine.Vector3 _posOffset;
public UnityEngine.Quaternion _rotOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Solver", new ResoniteLink.Reference() { });
members.Add("PositionTarget", new ResoniteLink.Reference() { });
members.Add("RotationTarget", new ResoniteLink.Reference() { });
members.Add("Weight", new ResoniteLink.Reference() { });
members.Add("_grabber", new ResoniteLink.Reference() { });
members.Add("_grabbingUser", new ResoniteLink.Reference() { });
members.Add("_holdSlot", new ResoniteLink.Reference() { });
members.Add("_posOffset", _posOffset.ToResoniteLinkField());
members.Add("_rotOffset", _rotOffset.ToResoniteLinkField());
}

}
}
