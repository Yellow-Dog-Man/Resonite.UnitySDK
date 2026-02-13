
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViewReferenceController
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PositionStream", new ResoniteLink.Reference() { });
members.Add("RotationStream", new ResoniteLink.Reference() { });
members.Add("ObjectSlot", new ResoniteLink.Reference() { });
members.Add("ShouldVoiceBeActive", ShouldVoiceBeActive.ToResoniteLinkField());
members.Add("_objectSlotScale", new ResoniteLink.Reference() { });
members.Add("_objectSlotActive", new ResoniteLink.Reference() { });
}

}
}
