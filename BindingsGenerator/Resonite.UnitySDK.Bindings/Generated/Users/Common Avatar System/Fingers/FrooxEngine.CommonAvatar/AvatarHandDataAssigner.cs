
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarHandDataAssigner
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarHandDataAssigner")]
public partial class AvatarHandDataAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent> TargetReference;
public global::FrooxEngine.TipTouchSource TouchSource;
public global::FrooxEngine.VibrationDeviceRelay VibrationRelay;
public global::Renderite.Shared.Chirality Chirality;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("TouchSource", TouchSource.ToResoniteReference(context));
members.Add("VibrationRelay", VibrationRelay.ToResoniteReference(context));
members.Add("Chirality", Chirality.ToResoniteLinkField());
members.Add("_equippingSlot", _equippingSlot.ToResoniteReference(context));
}

}
}
