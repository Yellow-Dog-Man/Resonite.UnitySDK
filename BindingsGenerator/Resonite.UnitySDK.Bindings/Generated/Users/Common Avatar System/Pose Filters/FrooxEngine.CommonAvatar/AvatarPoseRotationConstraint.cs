
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseRotationConstraint
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseRotationConstraint")]
public partial class AvatarPoseRotationConstraint : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter

{
    public global::System.Single MaxTwist { get => MaxTwist_Element.Data; set => MaxTwist_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTwist_Element = new();
public global::System.Single MaxSwing { get => MaxSwing_Element.Data; set => MaxSwing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSwing_Element = new();
public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public UnityEngine.Vector3 TwistReferenceAxis { get => TwistReferenceAxis_Element.Data; set => TwistReferenceAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TwistReferenceAxis_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxTwist", MaxTwist_Element.ToLinkField(context));
members.Add("MaxSwing", MaxSwing_Element.ToLinkField(context));
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("TwistReferenceAxis", TwistReferenceAxis_Element.ToLinkField(context));
}

}
}
