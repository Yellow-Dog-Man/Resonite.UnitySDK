
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarHandDataAssigner
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>> TargetReference_Element = new();
public global::FrooxEngine.TipTouchSource TouchSource { get => TouchSource_Element.Data; set => TouchSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TipTouchSource>, global::FrooxEngine.TipTouchSource> TouchSource_Element = new();
public global::FrooxEngine.VibrationDeviceRelay VibrationRelay { get => VibrationRelay_Element.Data; set => VibrationRelay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.VibrationDeviceRelay>, global::FrooxEngine.VibrationDeviceRelay> VibrationRelay_Element = new();
public global::Renderite.Shared.Chirality Chirality { get => Chirality_Element.Data; set => Chirality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Chirality_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot { get => _equippingSlot_Element.Data; set => _equippingSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> _equippingSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
members.Add("TouchSource", TouchSource_Element.ToLinkReference(context));
members.Add("VibrationRelay", VibrationRelay_Element.ToLinkReference(context));
members.Add("Chirality", Chirality_Element.ToLinkField(context));
members.Add("_equippingSlot", _equippingSlot_Element.ToLinkReference(context));
}

}
}
