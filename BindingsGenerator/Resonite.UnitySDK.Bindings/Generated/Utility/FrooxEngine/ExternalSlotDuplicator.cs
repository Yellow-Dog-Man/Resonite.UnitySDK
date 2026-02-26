
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExternalSlotDuplicator
// Generated on: čtvrtek 26. února 2026 12:28:16
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExternalSlotDuplicator")]
public partial class ExternalSlotDuplicator : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot TargetSlot { get => TargetSlot_Element.Data; set => TargetSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetSlot_Element = new();
public global::System.Nullable<UnityEngine.Vector3> LocalPositionOverride { get => LocalPositionOverride_Element.Data; set => LocalPositionOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> LocalPositionOverride_Element = new();
public global::System.Nullable<UnityEngine.Quaternion> LocalRotationOverride { get => LocalRotationOverride_Element.Data; set => LocalRotationOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Quaternion>>, global::System.Nullable<UnityEngine.Quaternion>> LocalRotationOverride_Element = new();
public global::System.Nullable<UnityEngine.Vector3> LocalScaleOverride { get => LocalScaleOverride_Element.Data; set => LocalScaleOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> LocalScaleOverride_Element = new();
public global::System.Nullable<global::System.Boolean> ActiveSelfOverride { get => ActiveSelfOverride_Element.Data; set => ActiveSelfOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> ActiveSelfOverride_Element = new();
public global::System.Boolean DoNotRestoreOriginalTransform { get => DoNotRestoreOriginalTransform_Element.Data; set => DoNotRestoreOriginalTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoNotRestoreOriginalTransform_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot_Element.ToLinkReference(context));
members.Add("LocalPositionOverride", LocalPositionOverride_Element.ToLinkField(context));
members.Add("LocalRotationOverride", LocalRotationOverride_Element.ToLinkField(context));
members.Add("LocalScaleOverride", LocalScaleOverride_Element.ToLinkField(context));
members.Add("ActiveSelfOverride", ActiveSelfOverride_Element.ToLinkField(context));
members.Add("DoNotRestoreOriginalTransform", DoNotRestoreOriginalTransform_Element.ToLinkField(context));
}

}
}
