
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor")]
public partial class AvatarAnchor : global::FrooxEngine.Component, global::FrooxEngine.IAvatarAnchor

{
    public global::System.Boolean Highlight;
public global::FrooxEngine.RootSpace ParentSpace;
public global::System.Single MinScale;
public global::System.Single MaxScale;
public global::FrooxEngine.UserRoot.UserNode PositionNode;
public global::FrooxEngine.Slot PositionReference;
public global::FrooxEngine.UserRoot.UserNode RotationNode;
public global::FrooxEngine.Slot RotationReference;
public global::System.Boolean PreserveUpOnEnter;
public global::System.Boolean PreserveUpOnExit;
public global::System.Boolean UnparentEverythingOnDestroy;
public global::FrooxEngine.CommonAvatar.AvatarAnchor.RestoreMode TransformRestoreMode;
public global::FrooxEngine.UserRoot.UserNode RestoreNode;
public global::FrooxEngine.Slot RestoreReference;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarAnchor.BodyNodeFilters> Filters;
public System.Collections.Generic.List<global::FrooxEngine.IAvatarAnchorUserFilter> UserFilters;
public global::FrooxEngine.Slot _originalSpace;
public UnityEngine.Vector3 _originalPosition;
public UnityEngine.Quaternion _originalRotation;
public global::System.Single _originalScale;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarObjectSlot> _dummyObjectSlots;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("ParentSpace", new ResoniteLink.SyncObject() { Members = ParentSpace.CollectMembers() });
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("PositionReference", new ResoniteLink.Reference() { });
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("RotationReference", new ResoniteLink.Reference() { });
members.Add("PreserveUpOnEnter", PreserveUpOnEnter.ToResoniteLinkField());
members.Add("PreserveUpOnExit", PreserveUpOnExit.ToResoniteLinkField());
members.Add("UnparentEverythingOnDestroy", UnparentEverythingOnDestroy.ToResoniteLinkField());
members.Add("TransformRestoreMode", TransformRestoreMode.ToResoniteLinkField());
members.Add("RestoreNode", RestoreNode.ToResoniteLinkField());
members.Add("RestoreReference", new ResoniteLink.Reference() { });
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("UserFilters", new ResoniteLink.SyncList()
{
    Elements = UserFilters.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_originalSpace", new ResoniteLink.Reference() { });
members.Add("_originalPosition", _originalPosition.ToResoniteLinkField());
members.Add("_originalRotation", _originalRotation.ToResoniteLinkField());
members.Add("_originalScale", _originalScale.ToResoniteLinkField());
members.Add("_dummyObjectSlots", new ResoniteLink.SyncList()
{
    Elements = _dummyObjectSlots.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
