
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotSaver
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExternalSlotSaver")]
public partial class ExternalSlotSaver : global::FrooxEngine.Component, global::FrooxEngine.IItemPermissions

{
    public global::FrooxEngine.Slot TargetSlot { get => TargetSlot_Element.Data; set => TargetSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetSlot_Element = new();
public global::System.Nullable<global::System.Boolean> SaveActiveSelfOverride { get => SaveActiveSelfOverride_Element.Data; set => SaveActiveSelfOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> SaveActiveSelfOverride_Element = new();
public global::System.Nullable<UnityEngine.Vector3> SaveLocalPositionOverride { get => SaveLocalPositionOverride_Element.Data; set => SaveLocalPositionOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> SaveLocalPositionOverride_Element = new();
public global::System.Nullable<UnityEngine.Quaternion> SaveLocalRotationOverride { get => SaveLocalRotationOverride_Element.Data; set => SaveLocalRotationOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Quaternion>>, global::System.Nullable<UnityEngine.Quaternion>> SaveLocalRotationOverride_Element = new();
public global::System.Nullable<UnityEngine.Vector3> SaveLocalScaleOverride { get => SaveLocalScaleOverride_Element.Data; set => SaveLocalScaleOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> SaveLocalScaleOverride_Element = new();
public global::System.Boolean IgnoreWhenNonPersistentSelf { get => IgnoreWhenNonPersistentSelf_Element.Data; set => IgnoreWhenNonPersistentSelf_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreWhenNonPersistentSelf_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot_Element.ToLinkReference(context));
members.Add("SaveActiveSelfOverride", SaveActiveSelfOverride_Element.ToLinkField(context));
members.Add("SaveLocalPositionOverride", SaveLocalPositionOverride_Element.ToLinkField(context));
members.Add("SaveLocalRotationOverride", SaveLocalRotationOverride_Element.ToLinkField(context));
members.Add("SaveLocalScaleOverride", SaveLocalScaleOverride_Element.ToLinkField(context));
members.Add("IgnoreWhenNonPersistentSelf", IgnoreWhenNonPersistentSelf_Element.ToLinkField(context));
}

}
}
