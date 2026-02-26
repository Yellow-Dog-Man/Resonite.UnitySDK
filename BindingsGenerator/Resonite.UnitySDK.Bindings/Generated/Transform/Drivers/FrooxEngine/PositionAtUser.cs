
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionAtUser
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PositionAtUser")]
public partial class PositionAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.User TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> TargetUser_Element = new();
public global::System.Boolean PositionAtLocalUser { get => PositionAtLocalUser_Element.Data; set => PositionAtLocalUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PositionAtLocalUser_Element = new();
public UnityEngine.Vector3 TargetPositionOffset { get => TargetPositionOffset_Element.Data; set => TargetPositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPositionOffset_Element = new();
public UnityEngine.Quaternion TargetRotationOffset { get => TargetRotationOffset_Element.Data; set => TargetRotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> TargetRotationOffset_Element = new();
public UnityEngine.Vector3 PositionOffset { get => PositionOffset_Element.Data; set => PositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PositionOffset_Element = new();
public UnityEngine.Quaternion RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RotationOffset_Element = new();
public global::FrooxEngine.UserRoot.UserNode PositionSource { get => PositionSource_Element.Data; set => PositionSource_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> PositionSource_Element = new();
public global::FrooxEngine.UserRoot.UserNode RotationSource { get => RotationSource_Element.Data; set => RotationSource_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RotationSource_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> PositionDrive { get => PositionDrive_Element.Data; set => PositionDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> PositionDrive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> RotationDrive { get => RotationDrive_Element.Data; set => RotationDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> RotationDrive_Element = new();
public global::System.Boolean RunAfterFinalPoseUpdate { get => RunAfterFinalPoseUpdate_Element.Data; set => RunAfterFinalPoseUpdate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RunAfterFinalPoseUpdate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("PositionAtLocalUser", PositionAtLocalUser_Element.ToLinkField(context));
members.Add("TargetPositionOffset", TargetPositionOffset_Element.ToLinkField(context));
members.Add("TargetRotationOffset", TargetRotationOffset_Element.ToLinkField(context));
members.Add("PositionOffset", PositionOffset_Element.ToLinkField(context));
members.Add("RotationOffset", RotationOffset_Element.ToLinkField(context));
members.Add("PositionSource", PositionSource_Element.ToLinkField(context));
members.Add("RotationSource", RotationSource_Element.ToLinkField(context));
members.Add("PositionDrive", PositionDrive_Element.ToLinkReference(context));
members.Add("RotationDrive", RotationDrive_Element.ToLinkReference(context));
members.Add("RunAfterFinalPoseUpdate", RunAfterFinalPoseUpdate_Element.ToLinkField(context));
}

}
}
