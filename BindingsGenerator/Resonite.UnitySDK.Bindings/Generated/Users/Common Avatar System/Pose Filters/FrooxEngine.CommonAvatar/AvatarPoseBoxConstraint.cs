
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseBoxConstraint")]
public partial class AvatarPoseBoxConstraint : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public UnityEngine.Vector3 BoxSize { get => BoxSize_Element.Data; set => BoxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BoxSize_Element = new();
public global::FrooxEngine.Slot DefaultPoseReference { get => DefaultPoseReference_Element.Data; set => DefaultPoseReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DefaultPoseReference_Element = new();
public global::System.Boolean ProcessSimulatedPoses { get => ProcessSimulatedPoses_Element.Data; set => ProcessSimulatedPoses_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessSimulatedPoses_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoxSize", BoxSize_Element.ToLinkField(context));
members.Add("DefaultPoseReference", DefaultPoseReference_Element.ToLinkReference(context));
members.Add("ProcessSimulatedPoses", ProcessSimulatedPoses_Element.ToLinkField(context));
}

}
}
