
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle")]
public partial class AvatarSlotEquippedToggle : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot;
public global::FrooxEngine.IField<global::System.Boolean> EquippedDrive;
public global::FrooxEngine.IField<global::System.Boolean> DequippedDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ObjectSlot", new ResoniteLink.Reference() { });
members.Add("EquippedDrive", new ResoniteLink.Reference() { });
members.Add("DequippedDrive", new ResoniteLink.Reference() { });
}

}
}
