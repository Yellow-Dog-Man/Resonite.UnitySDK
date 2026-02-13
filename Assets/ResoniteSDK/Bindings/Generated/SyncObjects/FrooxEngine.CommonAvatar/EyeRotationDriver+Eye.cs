
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver+Eye
// Generated on: pátek 13. února 2026 5:52:31
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class EyeRotationDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver+Eye")]
public partial class Eye : global::FrooxEngine.SyncObject, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.EyeSide Side;
public global::FrooxEngine.Slot Root;
public UnityEngine.Vector3 Up;
public UnityEngine.Vector3 ForwardDirection;
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("Up", Up.ToResoniteLinkField());
members.Add("ForwardDirection", ForwardDirection.ToResoniteLinkField());
members.Add("Rotation", new ResoniteLink.Reference() { });
}

}
            }
}
