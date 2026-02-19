
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle
// Generated on: čtvrtek 19. února 2026 8:00:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle")]
public partial class AvatarSlotEquippedToggle : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot;
public global::FrooxEngine.IField<global::System.Boolean> EquippedDrive;
public global::FrooxEngine.IField<global::System.Boolean> DequippedDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ObjectSlot", ObjectSlot.ToResoniteReference(context));
members.Add("EquippedDrive", EquippedDrive.ToResoniteReference(context));
members.Add("DequippedDrive", DequippedDrive.ToResoniteReference(context));
}

}
}
