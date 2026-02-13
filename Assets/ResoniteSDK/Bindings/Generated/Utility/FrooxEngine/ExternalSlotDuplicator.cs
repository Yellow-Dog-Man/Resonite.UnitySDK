
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotDuplicator
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExternalSlotDuplicator")]
public partial class ExternalSlotDuplicator : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot TargetSlot;
public global::System.Nullable<UnityEngine.Vector3> LocalPositionOverride;
public global::System.Nullable<UnityEngine.Quaternion> LocalRotationOverride;
public global::System.Nullable<UnityEngine.Vector3> LocalScaleOverride;
public global::System.Nullable<global::System.Boolean> ActiveSelfOverride;
public global::System.Boolean DoNotRestoreOriginalTransform;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSlot", new ResoniteLink.Reference() { });
members.Add("LocalPositionOverride", LocalPositionOverride.ToResoniteLinkField());
members.Add("LocalRotationOverride", LocalRotationOverride.ToResoniteLinkField());
members.Add("LocalScaleOverride", LocalScaleOverride.ToResoniteLinkField());
members.Add("ActiveSelfOverride", ActiveSelfOverride.ToResoniteLinkField());
members.Add("DoNotRestoreOriginalTransform", DoNotRestoreOriginalTransform.ToResoniteLinkField());
}

}
}
