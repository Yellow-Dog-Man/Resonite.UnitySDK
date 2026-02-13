
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInterfacePositioner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInterfacePositioner")]
public partial class UserInterfacePositioner : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef TargetUser;
public global::System.Boolean UseHead;
public global::System.Boolean RotateVerticalOnly;
public global::System.Single PositionSpeed;
public global::System.Single RotationSpeed;
public global::System.Single ActivationDistance;
public global::System.Single ActivationAngle;
public global::System.Single DeactivationDistance;
public global::System.Single DeactivationAngle;
public UnityEngine.Vector3 TargetPosition;
public UnityEngine.Quaternion TargetRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers() });
members.Add("UseHead", UseHead.ToResoniteLinkField());
members.Add("RotateVerticalOnly", RotateVerticalOnly.ToResoniteLinkField());
members.Add("PositionSpeed", PositionSpeed.ToResoniteLinkField());
members.Add("RotationSpeed", RotationSpeed.ToResoniteLinkField());
members.Add("ActivationDistance", ActivationDistance.ToResoniteLinkField());
members.Add("ActivationAngle", ActivationAngle.ToResoniteLinkField());
members.Add("DeactivationDistance", DeactivationDistance.ToResoniteLinkField());
members.Add("DeactivationAngle", DeactivationAngle.ToResoniteLinkField());
members.Add("TargetPosition", TargetPosition.ToResoniteLinkField());
members.Add("TargetRotation", TargetRotation.ToResoniteLinkField());
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_rotation", new ResoniteLink.Reference() { });
}

}
}
