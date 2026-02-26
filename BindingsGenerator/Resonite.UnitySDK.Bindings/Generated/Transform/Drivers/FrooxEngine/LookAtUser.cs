
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LookAtUser
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.User TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> TargetUser_Element = new();
public global::System.Boolean TargetAtLocalUser { get => TargetAtLocalUser_Element.Data; set => TargetAtLocalUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TargetAtLocalUser_Element = new();
public UnityEngine.Vector3 SourcePositionOffset { get => SourcePositionOffset_Element.Data; set => SourcePositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SourcePositionOffset_Element = new();
public global::System.Boolean Invert { get => Invert_Element.Data; set => Invert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Invert_Element = new();
public UnityEngine.Quaternion RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RotationOffset_Element = new();
public global::FrooxEngine.LookAtUser.UserNode PositionSource { get => PositionSource_Element.Data; set => PositionSource_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LookAtUser.UserNode>, global::FrooxEngine.LookAtUser.UserNode> PositionSource_Element = new();
public global::System.Boolean AroundAxis { get => AroundAxis_Element.Data; set => AroundAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AroundAxis_Element = new();
public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive { get => _rotationDrive_Element.Data; set => _rotationDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotationDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("TargetAtLocalUser", TargetAtLocalUser_Element.ToLinkField(context));
members.Add("SourcePositionOffset", SourcePositionOffset_Element.ToLinkField(context));
members.Add("Invert", Invert_Element.ToLinkField(context));
members.Add("RotationOffset", RotationOffset_Element.ToLinkField(context));
members.Add("PositionSource", PositionSource_Element.ToLinkField(context));
members.Add("AroundAxis", AroundAxis_Element.ToLinkField(context));
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("_rotationDrive", _rotationDrive_Element.ToLinkReference(context));
}

}
}
