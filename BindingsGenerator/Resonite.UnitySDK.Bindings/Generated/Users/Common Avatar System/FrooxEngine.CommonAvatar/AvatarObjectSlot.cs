
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectSlot
// Generated on: čtvrtek 26. února 2026 12:27:26
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject Equipped { get => Equipped_Element.Data; set => Equipped_Element.Data = value; }
public Field<global::FrooxEngine.LinkRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> Equipped_Element = new();
public global::Renderite.Shared.BodyNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> Node_Element = new();
public global::System.Boolean IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsTracking_Element = new();
public global::System.Boolean IsActive { get => IsActive_Element.Data; set => IsActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsActive_Element = new();
public global::System.Boolean IsSimulated { get => IsSimulated_Element.Data; set => IsSimulated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSimulated_Element = new();
public global::System.Boolean DriveActive { get => DriveActive_Element.Data; set => DriveActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DriveActive_Element = new();
public global::System.Boolean DriveScale { get => DriveScale_Element.Data; set => DriveScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DriveScale_Element = new();
public global::System.Boolean DoNotSimulate { get => DoNotSimulate_Element.Data; set => DoNotSimulate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoNotSimulate_Element = new();
public global::FrooxEngine.PrioritySyncRefList<global::FrooxEngine.CommonAvatar.IAvatarPoseFilter> Filters = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp _autoSmoothing { get => _autoSmoothing_Element.Data; set => _autoSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp>, global::FrooxEngine.CommonAvatar.AvatarPoseSmoothLerp> _autoSmoothing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority_Element.ToLinkField(context));
members.Add("Equipped", Equipped_Element.ToLinkReference(context));
members.Add("Node", Node_Element.ToLinkField(context));
members.Add("IsTracking", IsTracking_Element.ToLinkField(context));
members.Add("IsActive", IsActive_Element.ToLinkField(context));
members.Add("IsSimulated", IsSimulated_Element.ToLinkField(context));
members.Add("DriveActive", DriveActive_Element.ToLinkField(context));
members.Add("DriveScale", DriveScale_Element.ToLinkField(context));
members.Add("DoNotSimulate", DoNotSimulate_Element.ToLinkField(context));
members.Add("Filters", Filters.ToLinkSyncObject(context));
members.Add("_autoSmoothing", _autoSmoothing_Element.ToLinkReference(context));
}

}
}
