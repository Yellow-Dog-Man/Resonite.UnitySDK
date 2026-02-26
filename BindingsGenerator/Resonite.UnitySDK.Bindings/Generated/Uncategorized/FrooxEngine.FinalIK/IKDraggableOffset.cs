
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKDraggableOffset
// Generated on: čtvrtek 26. února 2026 10:04:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.FinalIK.IKSolver Solver { get => Solver_Element.Data; set => Solver_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FinalIK.IKSolver>, global::FrooxEngine.FinalIK.IKSolver> Solver_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Vector3> PositionTarget { get => PositionTarget_Element.Data; set => PositionTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<UnityEngine.Vector3>>, global::FrooxEngine.Sync<UnityEngine.Vector3>> PositionTarget_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Quaternion> RotationTarget { get => RotationTarget_Element.Data; set => RotationTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<UnityEngine.Quaternion>>, global::FrooxEngine.Sync<UnityEngine.Quaternion>> RotationTarget_Element = new();
public global::FrooxEngine.Sync<global::System.Single> Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> Weight_Element = new();
public global::FrooxEngine.Grabber _grabber { get => _grabber_Element.Data; set => _grabber_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _grabber_Element = new();
public global::FrooxEngine.User _grabbingUser { get => _grabbingUser_Element.Data; set => _grabbingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _grabbingUser_Element = new();
public global::FrooxEngine.Slot _holdSlot { get => _holdSlot_Element.Data; set => _holdSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _holdSlot_Element = new();
public UnityEngine.Vector3 _posOffset { get => _posOffset_Element.Data; set => _posOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _posOffset_Element = new();
public UnityEngine.Quaternion _rotOffset { get => _rotOffset_Element.Data; set => _rotOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _rotOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Solver", Solver_Element.Data.ToResoniteReference(context));
members.Add("PositionTarget", PositionTarget_Element.Data.ToResoniteReference(context));
members.Add("RotationTarget", RotationTarget_Element.Data.ToResoniteReference(context));
members.Add("Weight", Weight_Element.Data.ToResoniteReference(context));
members.Add("_grabber", _grabber_Element.Data.ToResoniteReference(context));
members.Add("_grabbingUser", _grabbingUser_Element.Data.ToResoniteReference(context));
members.Add("_holdSlot", _holdSlot_Element.Data.ToResoniteReference(context));
members.Add("_posOffset", _posOffset_Element.Data.ToResoniteLinkField());
members.Add("_rotOffset", _rotOffset_Element.Data.ToResoniteLinkField());
}

}
}
