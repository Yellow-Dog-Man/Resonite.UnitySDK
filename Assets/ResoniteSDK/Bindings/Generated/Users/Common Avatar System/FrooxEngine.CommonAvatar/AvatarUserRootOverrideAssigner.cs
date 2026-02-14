
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner")]
public partial class AvatarUserRootOverrideAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.Slot Override;
public global::FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner.OverrideNode Node;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Override", Override.ToResoniteReference(context));
members.Add("Node", Node.ToResoniteLinkField());
members.Add("_equippingSlot", _equippingSlot.ToResoniteReference(context));
}

}
}
