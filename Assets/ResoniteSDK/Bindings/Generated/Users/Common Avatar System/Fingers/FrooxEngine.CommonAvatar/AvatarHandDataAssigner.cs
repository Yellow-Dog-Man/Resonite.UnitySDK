
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarHandDataAssigner
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarHandDataAssigner")]
public partial class AvatarHandDataAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent> TargetReference;
public global::FrooxEngine.TipTouchSource TouchSource;
public global::FrooxEngine.VibrationDeviceRelay VibrationRelay;
public global::Renderite.Shared.Chirality Chirality;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetReference", new ResoniteLink.Reference() { });
members.Add("TouchSource", new ResoniteLink.Reference() { });
members.Add("VibrationRelay", new ResoniteLink.Reference() { });
members.Add("Chirality", Chirality.ToResoniteLinkField());
members.Add("_equippingSlot", new ResoniteLink.Reference() { });
}

}
}
