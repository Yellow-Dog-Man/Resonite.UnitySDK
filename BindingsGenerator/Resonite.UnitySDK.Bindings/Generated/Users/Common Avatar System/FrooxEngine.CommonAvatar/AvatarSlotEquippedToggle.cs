
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarSlotEquippedToggle")]
public partial class AvatarSlotEquippedToggle : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.AvatarObjectSlot ObjectSlot { get => ObjectSlot_Element.Data; set => ObjectSlot_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> ObjectSlot_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> EquippedDrive { get => EquippedDrive_Element.Data; set => EquippedDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> EquippedDrive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> DequippedDrive { get => DequippedDrive_Element.Data; set => DequippedDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> DequippedDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ObjectSlot", ObjectSlot_Element.Data.ToResoniteReference(context));
members.Add("EquippedDrive", EquippedDrive_Element.Data.ToResoniteReference(context));
members.Add("DequippedDrive", DequippedDrive_Element.Data.ToResoniteReference(context));
}

}
}
