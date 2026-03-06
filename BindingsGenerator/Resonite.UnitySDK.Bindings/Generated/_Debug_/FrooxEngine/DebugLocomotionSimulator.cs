
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLocomotionSimulator
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLocomotionSimulator")]
public partial class DebugLocomotionSimulator : global::FrooxEngine.Component

{
    public global::System.Boolean TrackPosition { get => TrackPosition_Element.Data; set => TrackPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TrackPosition_Element = new();
public global::FrooxEngine.LocomotionState State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LocomotionState>, global::FrooxEngine.LocomotionState> State_Element = new();
public UnityEngine.Vector3 MovementSpeed { get => MovementSpeed_Element.Data; set => MovementSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MovementSpeed_Element = new();
public global::System.Single AngularSpeed { get => AngularSpeed_Element.Data; set => AngularSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngularSpeed_Element = new();
public global::System.Boolean RotateDirection { get => RotateDirection_Element.Data; set => RotateDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RotateDirection_Element = new();
public global::System.Boolean OffsetRoot { get => OffsetRoot_Element.Data; set => OffsetRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OffsetRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TrackPosition", TrackPosition_Element.ToLinkField(context));
members.Add("State", State_Element.ToLinkField(context));
members.Add("MovementSpeed", MovementSpeed_Element.ToLinkField(context));
members.Add("AngularSpeed", AngularSpeed_Element.ToLinkField(context));
members.Add("RotateDirection", RotateDirection_Element.ToLinkField(context));
members.Add("OffsetRoot", OffsetRoot_Element.ToLinkField(context));
}

}
}
