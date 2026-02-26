
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViewReferenceController
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ViewReferenceController")]
public partial class ViewReferenceController : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IInputUpdateReceiver

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> PositionStream { get => PositionStream_Element.Data; set => PositionStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> PositionStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> RotationStream { get => RotationStream_Element.Data; set => RotationStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Quaternion>>, global::FrooxEngine.ValueStream<UnityEngine.Quaternion>> RotationStream_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot { get => ObjectSlot_Element.Data; set => ObjectSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> ObjectSlot_Element = new();
public global::System.Boolean ShouldVoiceBeActive { get => ShouldVoiceBeActive_Element.Data; set => ShouldVoiceBeActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> ShouldVoiceBeActive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _objectSlotScale { get => _objectSlotScale_Element.Data; set => _objectSlotScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _objectSlotScale_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _objectSlotActive { get => _objectSlotActive_Element.Data; set => _objectSlotActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _objectSlotActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionStream", PositionStream_Element.ToLinkReference(context));
members.Add("RotationStream", RotationStream_Element.ToLinkReference(context));
members.Add("ObjectSlot", ObjectSlot_Element.ToLinkReference(context));
members.Add("ShouldVoiceBeActive", ShouldVoiceBeActive_Element.ToLinkField(context));
members.Add("_objectSlotScale", _objectSlotScale_Element.ToLinkReference(context));
members.Add("_objectSlotActive", _objectSlotActive_Element.ToLinkReference(context));
}

}
}
