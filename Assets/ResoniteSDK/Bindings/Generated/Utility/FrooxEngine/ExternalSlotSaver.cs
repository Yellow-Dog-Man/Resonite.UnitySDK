
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotSaver
// Generated on: pátek 13. února 2026 5:52:39
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExternalSlotSaver")]
public partial class ExternalSlotSaver : global::FrooxEngine.Component, global::FrooxEngine.IItemPermissions

{
    public global::FrooxEngine.Slot TargetSlot;
public global::System.Nullable<global::System.Boolean> SaveActiveSelfOverride;
public global::System.Nullable<UnityEngine.Vector3> SaveLocalPositionOverride;
public global::System.Nullable<UnityEngine.Quaternion> SaveLocalRotationOverride;
public global::System.Nullable<UnityEngine.Vector3> SaveLocalScaleOverride;
public global::System.Boolean IgnoreWhenNonPersistentSelf;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSlot", new ResoniteLink.Reference() { });
members.Add("SaveActiveSelfOverride", SaveActiveSelfOverride.ToResoniteLinkField());
members.Add("SaveLocalPositionOverride", SaveLocalPositionOverride.ToResoniteLinkField());
members.Add("SaveLocalRotationOverride", SaveLocalRotationOverride.ToResoniteLinkField());
members.Add("SaveLocalScaleOverride", SaveLocalScaleOverride.ToResoniteLinkField());
members.Add("IgnoreWhenNonPersistentSelf", IgnoreWhenNonPersistentSelf.ToResoniteLinkField());
}

}
}
