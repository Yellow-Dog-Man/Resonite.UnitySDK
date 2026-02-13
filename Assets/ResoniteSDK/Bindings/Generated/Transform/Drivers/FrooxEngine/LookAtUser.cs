
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LookAtUser
// Generated on: pátek 13. února 2026 23:23:09
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LookAtUser")]
public partial class LookAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.User TargetUser;
public global::System.Boolean TargetAtLocalUser;
public UnityEngine.Vector3 SourcePositionOffset;
public global::System.Boolean Invert;
public UnityEngine.Quaternion RotationOffset;
public global::FrooxEngine.LookAtUser.UserNode PositionSource;
public global::System.Boolean AroundAxis;
public UnityEngine.Vector3 Axis;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotationDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.Reference() { });
members.Add("TargetAtLocalUser", TargetAtLocalUser.ToResoniteLinkField());
members.Add("SourcePositionOffset", SourcePositionOffset.ToResoniteLinkField());
members.Add("Invert", Invert.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("PositionSource", PositionSource.ToResoniteLinkField());
members.Add("AroundAxis", AroundAxis.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("_rotationDrive", new ResoniteLink.Reference() { });
}

}
}
