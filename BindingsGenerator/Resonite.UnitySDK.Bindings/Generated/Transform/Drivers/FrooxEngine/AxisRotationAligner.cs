
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisRotationAligner
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisRotationAligner")]
public partial class AxisRotationAligner : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LocalDirection { get => LocalDirection_Element.Data; set => LocalDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalDirection_Element = new();
public UnityEngine.Vector3 TargetDirection { get => TargetDirection_Element.Data; set => TargetDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetDirection_Element = new();
public global::FrooxEngine.RootSpace DirectionSpace = new();
public UnityEngine.Quaternion LocalRotation { get => LocalRotation_Element.Data; set => LocalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LocalRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalDirection", LocalDirection_Element.ToLinkField(context));
members.Add("TargetDirection", TargetDirection_Element.ToLinkField(context));
members.Add("DirectionSpace", DirectionSpace.ToLinkSyncObject(context));
members.Add("LocalRotation", LocalRotation_Element.ToLinkField(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
}
