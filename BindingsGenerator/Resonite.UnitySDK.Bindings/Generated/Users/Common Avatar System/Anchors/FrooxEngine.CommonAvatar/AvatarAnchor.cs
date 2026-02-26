
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor
// Generated on: čtvrtek 26. února 2026 10:04:06
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor")]
public partial class AvatarAnchor : global::FrooxEngine.Component, global::FrooxEngine.IAvatarAnchor

{
    public global::System.Boolean Highlight { get => Highlight_Element.Data; set => Highlight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Highlight_Element = new();
public global::FrooxEngine.RootSpace ParentSpace = new();
public global::System.Single MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinScale_Element = new();
public global::System.Single MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxScale_Element = new();
public global::FrooxEngine.UserRoot.UserNode PositionNode { get => PositionNode_Element.Data; set => PositionNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> PositionNode_Element = new();
public global::FrooxEngine.Slot PositionReference { get => PositionReference_Element.Data; set => PositionReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PositionReference_Element = new();
public global::FrooxEngine.UserRoot.UserNode RotationNode { get => RotationNode_Element.Data; set => RotationNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RotationNode_Element = new();
public global::FrooxEngine.Slot RotationReference { get => RotationReference_Element.Data; set => RotationReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> RotationReference_Element = new();
public global::System.Boolean PreserveUpOnEnter { get => PreserveUpOnEnter_Element.Data; set => PreserveUpOnEnter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveUpOnEnter_Element = new();
public global::System.Boolean PreserveUpOnExit { get => PreserveUpOnExit_Element.Data; set => PreserveUpOnExit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveUpOnExit_Element = new();
public global::System.Boolean UnparentEverythingOnDestroy { get => UnparentEverythingOnDestroy_Element.Data; set => UnparentEverythingOnDestroy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UnparentEverythingOnDestroy_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarAnchor.RestoreMode TransformRestoreMode { get => TransformRestoreMode_Element.Data; set => TransformRestoreMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.AvatarAnchor.RestoreMode>, global::FrooxEngine.CommonAvatar.AvatarAnchor.RestoreMode> TransformRestoreMode_Element = new();
public global::FrooxEngine.UserRoot.UserNode RestoreNode { get => RestoreNode_Element.Data; set => RestoreNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RestoreNode_Element = new();
public global::FrooxEngine.Slot RestoreReference { get => RestoreReference_Element.Data; set => RestoreReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> RestoreReference_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.AvatarAnchor.BodyNodeFilters>, global::FrooxEngine.CommonAvatar.AvatarAnchor.BodyNodeFilters> Filters = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IAvatarAnchorUserFilter>, global::FrooxEngine.IAvatarAnchorUserFilter, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IAvatarAnchorUserFilter>, global::FrooxEngine.IAvatarAnchorUserFilter>> UserFilters = new();
public global::FrooxEngine.Slot _originalSpace { get => _originalSpace_Element.Data; set => _originalSpace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _originalSpace_Element = new();
public UnityEngine.Vector3 _originalPosition { get => _originalPosition_Element.Data; set => _originalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _originalPosition_Element = new();
public UnityEngine.Quaternion _originalRotation { get => _originalRotation_Element.Data; set => _originalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _originalRotation_Element = new();
public global::System.Single _originalScale { get => _originalScale_Element.Data; set => _originalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _originalScale_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot>> _dummyObjectSlots = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Highlight", Highlight_Element.Data.ToResoniteLinkField());
members.Add("ParentSpace", new ResoniteLink.SyncObject() { Members = ParentSpace.CollectMembers(context) });
members.Add("MinScale", MinScale_Element.Data.ToResoniteLinkField());
members.Add("MaxScale", MaxScale_Element.Data.ToResoniteLinkField());
members.Add("PositionNode", PositionNode_Element.Data.ToResoniteLinkField());
members.Add("PositionReference", PositionReference_Element.Data.ToResoniteReference(context));
members.Add("RotationNode", RotationNode_Element.Data.ToResoniteLinkField());
members.Add("RotationReference", RotationReference_Element.Data.ToResoniteReference(context));
members.Add("PreserveUpOnEnter", PreserveUpOnEnter_Element.Data.ToResoniteLinkField());
members.Add("PreserveUpOnExit", PreserveUpOnExit_Element.Data.ToResoniteLinkField());
members.Add("UnparentEverythingOnDestroy", UnparentEverythingOnDestroy_Element.Data.ToResoniteLinkField());
members.Add("TransformRestoreMode", TransformRestoreMode_Element.Data.ToResoniteLinkField());
members.Add("RestoreNode", RestoreNode_Element.Data.ToResoniteLinkField());
members.Add("RestoreReference", RestoreReference_Element.Data.ToResoniteReference(context));
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("UserFilters", new ResoniteLink.SyncList()
{
    Elements = UserFilters.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_originalSpace", _originalSpace_Element.Data.ToResoniteReference(context));
members.Add("_originalPosition", _originalPosition_Element.Data.ToResoniteLinkField());
members.Add("_originalRotation", _originalRotation_Element.Data.ToResoniteLinkField());
members.Add("_originalScale", _originalScale_Element.Data.ToResoniteLinkField());
members.Add("_dummyObjectSlots", new ResoniteLink.SyncList()
{
    Elements = _dummyObjectSlots.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
