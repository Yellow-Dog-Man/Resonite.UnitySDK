
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotDuplicator
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
members.Add("LocalPositionOverride", LocalPositionOverride.ToResoniteLinkField());
members.Add("LocalRotationOverride", LocalRotationOverride.ToResoniteLinkField());
members.Add("LocalScaleOverride", LocalScaleOverride.ToResoniteLinkField());
members.Add("ActiveSelfOverride", ActiveSelfOverride.ToResoniteLinkField());
members.Add("DoNotRestoreOriginalTransform", DoNotRestoreOriginalTransform.ToResoniteLinkField());
}

}
}
