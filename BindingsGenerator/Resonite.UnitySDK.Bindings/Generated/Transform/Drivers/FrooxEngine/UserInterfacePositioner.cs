
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInterfacePositioner
// Generated on: čtvrtek 26. února 2026 15:09:08
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UserRef TargetUser = new();
public global::System.Boolean UseHead { get => UseHead_Element.Data; set => UseHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseHead_Element = new();
public global::System.Boolean RotateVerticalOnly { get => RotateVerticalOnly_Element.Data; set => RotateVerticalOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RotateVerticalOnly_Element = new();
public global::System.Single PositionSpeed { get => PositionSpeed_Element.Data; set => PositionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSpeed_Element = new();
public global::System.Single RotationSpeed { get => RotationSpeed_Element.Data; set => RotationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationSpeed_Element = new();
public global::System.Single ActivationDistance { get => ActivationDistance_Element.Data; set => ActivationDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationDistance_Element = new();
public global::System.Single ActivationAngle { get => ActivationAngle_Element.Data; set => ActivationAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationAngle_Element = new();
public global::System.Single DeactivationDistance { get => DeactivationDistance_Element.Data; set => DeactivationDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DeactivationDistance_Element = new();
public global::System.Single DeactivationAngle { get => DeactivationAngle_Element.Data; set => DeactivationAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DeactivationAngle_Element = new();
public UnityEngine.Vector3 TargetPosition { get => TargetPosition_Element.Data; set => TargetPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPosition_Element = new();
public UnityEngine.Quaternion TargetRotation { get => TargetRotation_Element.Data; set => TargetRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> TargetRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToLinkSyncObject(context));
members.Add("UseHead", UseHead_Element.ToLinkField(context));
members.Add("RotateVerticalOnly", RotateVerticalOnly_Element.ToLinkField(context));
members.Add("PositionSpeed", PositionSpeed_Element.ToLinkField(context));
members.Add("RotationSpeed", RotationSpeed_Element.ToLinkField(context));
members.Add("ActivationDistance", ActivationDistance_Element.ToLinkField(context));
members.Add("ActivationAngle", ActivationAngle_Element.ToLinkField(context));
members.Add("DeactivationDistance", DeactivationDistance_Element.ToLinkField(context));
members.Add("DeactivationAngle", DeactivationAngle_Element.ToLinkField(context));
members.Add("TargetPosition", TargetPosition_Element.ToLinkField(context));
members.Add("TargetRotation", TargetRotation_Element.ToLinkField(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
}
