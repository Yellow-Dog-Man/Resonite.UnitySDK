
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor
// Generated on: úterý 24. února 2026 18:18:57
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("ParentSpace", new ResoniteLink.SyncObject() { Members = ParentSpace.CollectMembers(context) });
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("PositionReference", PositionReference.ToResoniteReference(context));
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("RotationReference", RotationReference.ToResoniteReference(context));
members.Add("PreserveUpOnEnter", PreserveUpOnEnter.ToResoniteLinkField());
members.Add("PreserveUpOnExit", PreserveUpOnExit.ToResoniteLinkField());
members.Add("UnparentEverythingOnDestroy", UnparentEverythingOnDestroy.ToResoniteLinkField());
members.Add("TransformRestoreMode", TransformRestoreMode.ToResoniteLinkField());
members.Add("RestoreNode", RestoreNode.ToResoniteLinkField());
members.Add("RestoreReference", RestoreReference.ToResoniteReference(context));
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("UserFilters", new ResoniteLink.SyncList()
{
    Elements = UserFilters.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_originalSpace", _originalSpace.ToResoniteReference(context));
members.Add("_originalPosition", _originalPosition.ToResoniteLinkField());
members.Add("_originalRotation", _originalRotation.ToResoniteLinkField());
members.Add("_originalScale", _originalScale.ToResoniteLinkField());
members.Add("_dummyObjectSlots", new ResoniteLink.SyncList()
{
    Elements = _dummyObjectSlots.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
