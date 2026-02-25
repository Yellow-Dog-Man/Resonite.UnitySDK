
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LookAtUser
// Generated on: středa 25. února 2026 16:14:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LookAtUser")]
public partial class LookAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.User TargetUser;
public global::System.Boolean TargetAtLocalUser;
public UnityEngine.Vector3 SourcePositionOffset;
public global::System.Boolean Invert;
public UnityEngine.Quaternion RotationOffset;
public global::FrooxEngine.LookAtUser.UserNode PositionSource;
public global::System.Boolean AroundAxis;
public UnityEngine.Vector3 Axis;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("TargetAtLocalUser", TargetAtLocalUser.ToResoniteLinkField());
members.Add("SourcePositionOffset", SourcePositionOffset.ToResoniteLinkField());
members.Add("Invert", Invert.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("PositionSource", PositionSource.ToResoniteLinkField());
members.Add("AroundAxis", AroundAxis.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("_rotationDrive", _rotationDrive.ToResoniteReference(context));
}

}
}
