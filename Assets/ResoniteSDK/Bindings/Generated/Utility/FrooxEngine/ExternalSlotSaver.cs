
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotSaver
// Generated on: úterý 24. února 2026 18:20:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExternalSlotSaver")]
public partial class ExternalSlotSaver : global::FrooxEngine.Component, global::FrooxEngine.IItemPermissions

{
    public global::FrooxEngine.Slot TargetSlot;
public global::System.Nullable<global::System.Boolean> SaveActiveSelfOverride;
public global::System.Nullable<UnityEngine.Vector3> SaveLocalPositionOverride;
public global::System.Nullable<UnityEngine.Quaternion> SaveLocalRotationOverride;
public global::System.Nullable<UnityEngine.Vector3> SaveLocalScaleOverride;
public global::System.Boolean IgnoreWhenNonPersistentSelf;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
members.Add("SaveActiveSelfOverride", SaveActiveSelfOverride.ToResoniteLinkField());
members.Add("SaveLocalPositionOverride", SaveLocalPositionOverride.ToResoniteLinkField());
members.Add("SaveLocalRotationOverride", SaveLocalRotationOverride.ToResoniteLinkField());
members.Add("SaveLocalScaleOverride", SaveLocalScaleOverride.ToResoniteLinkField());
members.Add("IgnoreWhenNonPersistentSelf", IgnoreWhenNonPersistentSelf.ToResoniteLinkField());
}

}
}
