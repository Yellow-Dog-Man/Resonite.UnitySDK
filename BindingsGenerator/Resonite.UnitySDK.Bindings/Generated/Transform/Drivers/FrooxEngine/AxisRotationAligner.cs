
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisRotationAligner
// Generated on: středa 25. února 2026 16:14:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisRotationAligner")]
public partial class AxisRotationAligner : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LocalDirection;
public UnityEngine.Vector3 TargetDirection;
public global::FrooxEngine.RootSpace DirectionSpace;
public UnityEngine.Quaternion LocalRotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalDirection", LocalDirection.ToResoniteLinkField());
members.Add("TargetDirection", TargetDirection.ToResoniteLinkField());
members.Add("DirectionSpace", new ResoniteLink.SyncObject() { Members = DirectionSpace.CollectMembers(context) });
members.Add("LocalRotation", LocalRotation.ToResoniteLinkField());
members.Add("_rotation", _rotation.ToResoniteReference(context));
}

}
}
