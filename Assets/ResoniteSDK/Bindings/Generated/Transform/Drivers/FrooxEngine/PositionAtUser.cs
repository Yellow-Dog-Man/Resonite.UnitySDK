
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionAtUser
// Generated on: pátek 13. února 2026 5:52:26
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.Reference() { });
members.Add("PositionAtLocalUser", PositionAtLocalUser.ToResoniteLinkField());
members.Add("TargetPositionOffset", TargetPositionOffset.ToResoniteLinkField());
members.Add("TargetRotationOffset", TargetRotationOffset.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("PositionSource", PositionSource.ToResoniteLinkField());
members.Add("RotationSource", RotationSource.ToResoniteLinkField());
members.Add("PositionDrive", new ResoniteLink.Reference() { });
members.Add("RotationDrive", new ResoniteLink.Reference() { });
members.Add("RunAfterFinalPoseUpdate", RunAfterFinalPoseUpdate.ToResoniteLinkField());
}

}
}
