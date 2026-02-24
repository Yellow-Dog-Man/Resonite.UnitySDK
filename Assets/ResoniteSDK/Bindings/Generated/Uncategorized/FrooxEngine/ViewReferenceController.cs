
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViewReferenceController
// Generated on: úterý 24. února 2026 18:20:30
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> PositionStream;
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> RotationStream;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot;
public global::System.Boolean ShouldVoiceBeActive;
public global::FrooxEngine.IField<UnityEngine.Vector3> _objectSlotScale;
public global::FrooxEngine.IField<global::System.Boolean> _objectSlotActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionStream", PositionStream.ToResoniteReference(context));
members.Add("RotationStream", RotationStream.ToResoniteReference(context));
members.Add("ObjectSlot", ObjectSlot.ToResoniteReference(context));
members.Add("ShouldVoiceBeActive", ShouldVoiceBeActive.ToResoniteLinkField());
members.Add("_objectSlotScale", _objectSlotScale.ToResoniteReference(context));
members.Add("_objectSlotActive", _objectSlotActive.ToResoniteReference(context));
}

}
}
