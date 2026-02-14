
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectSlot
// Generated on: sobota 14. února 2026 8:57:47
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectSlot")]
public partial class AvatarObjectSlot : global::FrooxEngine.UserRootComponent

{
    public global::System.Int32 Priority;
public global::FrooxEngine.CommonAvatar.IAvatarObject Equipped;
public global::Renderite.Shared.BodyNode Node;
public global::System.Boolean IsTracking;
public global::System.Boolean IsActive;
public global::System.Boolean IsSimulated;
public global::System.Boolean DriveActive;
public global::System.Boolean DriveScale;
public global::System.Boolean DoNotSimulate;
public global::FrooxEngine.PrioritySyncRefList<global::FrooxEngine.CommonAvatar.IAvatarPoseFilter> Filters;
public global::FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp _autoSmoothing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("Equipped", Equipped.ToResoniteReference(context));
members.Add("Node", Node.ToResoniteLinkField());
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("IsSimulated", IsSimulated.ToResoniteLinkField());
members.Add("DriveActive", DriveActive.ToResoniteLinkField());
members.Add("DriveScale", DriveScale.ToResoniteLinkField());
members.Add("DoNotSimulate", DoNotSimulate.ToResoniteLinkField());
members.Add("Filters", new ResoniteLink.SyncObject() { Members = Filters.CollectMembers(context) });
members.Add("_autoSmoothing", _autoSmoothing.ToResoniteReference(context));
}

}
}
