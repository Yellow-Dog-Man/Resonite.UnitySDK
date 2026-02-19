
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKDraggableOffset
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Solver", Solver.ToResoniteReference(context));
members.Add("PositionTarget", PositionTarget.ToResoniteReference(context));
members.Add("RotationTarget", RotationTarget.ToResoniteReference(context));
members.Add("Weight", Weight.ToResoniteReference(context));
members.Add("_grabber", _grabber.ToResoniteReference(context));
members.Add("_grabbingUser", _grabbingUser.ToResoniteReference(context));
members.Add("_holdSlot", _holdSlot.ToResoniteReference(context));
members.Add("_posOffset", _posOffset.ToResoniteLinkField());
members.Add("_rotOffset", _rotOffset.ToResoniteLinkField());
}

}
}
