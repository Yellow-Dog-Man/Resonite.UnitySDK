
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectSlot
// Generated on: pátek 13. února 2026 23:22:19
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("Equipped", new ResoniteLink.Reference() { });
members.Add("Node", Node.ToResoniteLinkField());
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("IsSimulated", IsSimulated.ToResoniteLinkField());
members.Add("DriveActive", DriveActive.ToResoniteLinkField());
members.Add("DriveScale", DriveScale.ToResoniteLinkField());
members.Add("DoNotSimulate", DoNotSimulate.ToResoniteLinkField());
members.Add("Filters", new ResoniteLink.SyncObject() { Members = Filters.CollectMembers() });
members.Add("_autoSmoothing", new ResoniteLink.Reference() { });
}

}
}
