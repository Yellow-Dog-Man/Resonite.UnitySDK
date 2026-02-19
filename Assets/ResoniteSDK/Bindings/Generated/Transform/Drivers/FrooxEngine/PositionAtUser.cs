
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionAtUser
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PositionAtUser")]
public partial class PositionAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.User TargetUser;
public global::System.Boolean PositionAtLocalUser;
public UnityEngine.Vector3 TargetPositionOffset;
public UnityEngine.Quaternion TargetRotationOffset;
public UnityEngine.Vector3 PositionOffset;
public UnityEngine.Quaternion RotationOffset;
public global::FrooxEngine.UserRoot.UserNode PositionSource;
public global::FrooxEngine.UserRoot.UserNode RotationSource;
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive;
public global::FrooxEngine.IField<UnityEngine.Quaternion> RotationDrive;
public global::System.Boolean RunAfterFinalPoseUpdate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("PositionAtLocalUser", PositionAtLocalUser.ToResoniteLinkField());
members.Add("TargetPositionOffset", TargetPositionOffset.ToResoniteLinkField());
members.Add("TargetRotationOffset", TargetRotationOffset.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("PositionSource", PositionSource.ToResoniteLinkField());
members.Add("RotationSource", RotationSource.ToResoniteLinkField());
members.Add("PositionDrive", PositionDrive.ToResoniteReference(context));
members.Add("RotationDrive", RotationDrive.ToResoniteReference(context));
members.Add("RunAfterFinalPoseUpdate", RunAfterFinalPoseUpdate.ToResoniteLinkField());
}

}
}
