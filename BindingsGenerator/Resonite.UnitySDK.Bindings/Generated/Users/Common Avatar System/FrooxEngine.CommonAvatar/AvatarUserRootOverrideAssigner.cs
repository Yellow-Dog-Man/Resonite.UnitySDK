
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner")]
public partial class AvatarUserRootOverrideAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.Slot Override { get => Override_Element.Data; set => Override_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Override_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner.OverrideNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner.OverrideNode>, global::FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner.OverrideNode> Node_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot { get => _equippingSlot_Element.Data; set => _equippingSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> _equippingSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Override", Override_Element.ToLinkReference(context));
members.Add("Node", Node_Element.ToLinkField(context));
members.Add("_equippingSlot", _equippingSlot_Element.ToLinkReference(context));
}

}
}
