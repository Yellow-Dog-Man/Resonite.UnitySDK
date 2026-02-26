
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SmoothTransform
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SmoothTransform")]
public partial class SmoothTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.RootSpace InterpolationSpace = new();
public UnityEngine.Vector3 TargetPosition { get => TargetPosition_Element.Data; set => TargetPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPosition_Element = new();
public UnityEngine.Quaternion TargetRotation { get => TargetRotation_Element.Data; set => TargetRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> TargetRotation_Element = new();
public UnityEngine.Vector3 TargetScale { get => TargetScale_Element.Data; set => TargetScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> Rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Scale_Element = new();
public global::System.Single SmoothSpeed { get => SmoothSpeed_Element.Data; set => SmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothSpeed_Element = new();
public global::System.Int32 _updateIndex { get => _updateIndex_Element.Data; set => _updateIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _updateIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InterpolationSpace", InterpolationSpace.ToLinkSyncObject(context));
members.Add("TargetPosition", TargetPosition_Element.ToLinkField(context));
members.Add("TargetRotation", TargetRotation_Element.ToLinkField(context));
members.Add("TargetScale", TargetScale_Element.ToLinkField(context));
members.Add("Position", Position_Element.ToLinkReference(context));
members.Add("Rotation", Rotation_Element.ToLinkReference(context));
members.Add("Scale", Scale_Element.ToLinkReference(context));
members.Add("SmoothSpeed", SmoothSpeed_Element.ToLinkField(context));
members.Add("_updateIndex", _updateIndex_Element.ToLinkField(context));
}

}
}
