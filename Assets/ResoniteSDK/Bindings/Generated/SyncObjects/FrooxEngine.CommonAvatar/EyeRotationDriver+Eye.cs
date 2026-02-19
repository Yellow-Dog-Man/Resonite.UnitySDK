
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeRotationDriver+Eye
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("Root", Root.ToResoniteReference(context));
members.Add("Up", Up.ToResoniteLinkField());
members.Add("ForwardDirection", ForwardDirection.ToResoniteLinkField());
members.Add("Rotation", Rotation.ToResoniteReference(context));
}

}
            }
}
