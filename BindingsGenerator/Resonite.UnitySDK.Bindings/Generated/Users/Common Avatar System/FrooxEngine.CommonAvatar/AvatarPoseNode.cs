
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseNode
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarPoseNode")]
public partial class AvatarPoseNode : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObject, global::FrooxEngine.IInputUpdateReceiver

{
    public global::Renderite.Shared.BodyNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> Node_Element = new();
public global::System.Int32 EquipOrderPriority { get => EquipOrderPriority_Element.Data; set => EquipOrderPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EquipOrderPriority_Element = new();
public global::System.Boolean RunAfterInputUpdate { get => RunAfterInputUpdate_Element.Data; set => RunAfterInputUpdate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RunAfterInputUpdate_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode, Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode>> MutuallyExclusiveNodes = new();
public global::System.Boolean IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsTracking_Element = new();
public global::System.Boolean SourceIsTracking { get => SourceIsTracking_Element.Data; set => SourceIsTracking_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> SourceIsTracking_Element = new();
public global::System.Boolean SourceIsActive { get => SourceIsActive_Element.Data; set => SourceIsActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> SourceIsActive_Element = new();
public global::System.Boolean SourceIsSimulated { get => SourceIsSimulated_Element.Data; set => SourceIsSimulated_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> SourceIsSimulated_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _objectSlot { get => _objectSlot_Element.Data; set => _objectSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> _objectSlot_Element = new();
public global::FrooxEngine.Slot _source { get => _source_Element.Data; set => _source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _source_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _active { get => _active_Element.Data; set => _active_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _active_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.Data.ToResoniteLinkField());
members.Add("EquipOrderPriority", EquipOrderPriority_Element.Data.ToResoniteLinkField());
members.Add("RunAfterInputUpdate", RunAfterInputUpdate_Element.Data.ToResoniteLinkField());
members.Add("MutuallyExclusiveNodes", new ResoniteLink.SyncList()
{
    Elements = MutuallyExclusiveNodes.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
members.Add("IsTracking", IsTracking_Element.Data.ToResoniteLinkField());
members.Add("SourceIsTracking", SourceIsTracking_Element.Data.ToResoniteLinkField());
members.Add("SourceIsActive", SourceIsActive_Element.Data.ToResoniteLinkField());
members.Add("SourceIsSimulated", SourceIsSimulated_Element.Data.ToResoniteLinkField());
members.Add("_objectSlot", _objectSlot_Element.Data.ToResoniteReference(context));
members.Add("_source", _source_Element.Data.ToResoniteReference(context));
members.Add("_position", _position_Element.Data.ToResoniteReference(context));
members.Add("_rotation", _rotation_Element.Data.ToResoniteReference(context));
members.Add("_scale", _scale_Element.Data.ToResoniteReference(context));
members.Add("_active", _active_Element.Data.ToResoniteReference(context));
}

}
}
