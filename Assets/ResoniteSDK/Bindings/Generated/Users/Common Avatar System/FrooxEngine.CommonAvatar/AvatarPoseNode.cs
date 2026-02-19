
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseNode
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseNode")]
public partial class AvatarPoseNode : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObject, global::FrooxEngine.IInputUpdateReceiver

{
    public global::Renderite.Shared.BodyNode Node;
public global::System.Int32 EquipOrderPriority;
public global::System.Boolean RunAfterInputUpdate;
public System.Collections.Generic.List<global::Renderite.Shared.BodyNode> MutuallyExclusiveNodes;
public global::System.Boolean IsTracking;
public global::System.Boolean SourceIsTracking;
public global::System.Boolean SourceIsActive;
public global::System.Boolean SourceIsSimulated;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _objectSlot;
public global::FrooxEngine.Slot _source;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;
public global::FrooxEngine.IField<global::System.Boolean> _active;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("EquipOrderPriority", EquipOrderPriority.ToResoniteLinkField());
members.Add("RunAfterInputUpdate", RunAfterInputUpdate.ToResoniteLinkField());
members.Add("MutuallyExclusiveNodes", new ResoniteLink.SyncList()
{
    Elements = MutuallyExclusiveNodes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("SourceIsTracking", SourceIsTracking.ToResoniteLinkField());
members.Add("SourceIsActive", SourceIsActive.ToResoniteLinkField());
members.Add("SourceIsSimulated", SourceIsSimulated.ToResoniteLinkField());
members.Add("_objectSlot", _objectSlot.ToResoniteReference(context));
members.Add("_source", _source.ToResoniteReference(context));
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
members.Add("_scale", _scale.ToResoniteReference(context));
members.Add("_active", _active.ToResoniteReference(context));
}

}
}
