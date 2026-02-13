
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner
// Generated on: pátek 13. února 2026 23:23:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner")]
public partial class AvatarUserRootOverrideAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.Slot Override;
public global::FrooxEngine.CommonAvatar.AvatarUserRootOverrideAssigner.OverrideNode Node;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Override", new ResoniteLink.Reference() { });
members.Add("Node", Node.ToResoniteLinkField());
members.Add("_equippingSlot", new ResoniteLink.Reference() { });
}

}
}
