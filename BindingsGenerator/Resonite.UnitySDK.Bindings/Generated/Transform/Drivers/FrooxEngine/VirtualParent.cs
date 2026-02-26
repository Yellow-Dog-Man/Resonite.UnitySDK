
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualParent
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualParent")]
public partial class VirtualParent : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot OverrideParent { get => OverrideParent_Element.Data; set => OverrideParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideParent_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetPos { get => _targetPos_Element.Data; set => _targetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _targetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _targetRot { get => _targetRot_Element.Data; set => _targetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _targetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetScl { get => _targetScl_Element.Data; set => _targetScl_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _targetScl_Element = new();
public UnityEngine.Vector3 LocalPosition { get => LocalPosition_Element.Data; set => LocalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalPosition_Element = new();
public UnityEngine.Quaternion LocalRotation { get => LocalRotation_Element.Data; set => LocalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LocalRotation_Element = new();
public UnityEngine.Vector3 LocalScale { get => LocalScale_Element.Data; set => LocalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideParent", OverrideParent_Element.ToLinkReference(context));
members.Add("_targetPos", _targetPos_Element.ToLinkReference(context));
members.Add("_targetRot", _targetRot_Element.ToLinkReference(context));
members.Add("_targetScl", _targetScl_Element.ToLinkReference(context));
members.Add("LocalPosition", LocalPosition_Element.ToLinkField(context));
members.Add("LocalRotation", LocalRotation_Element.ToLinkField(context));
members.Add("LocalScale", LocalScale_Element.ToLinkField(context));
}

}
}
