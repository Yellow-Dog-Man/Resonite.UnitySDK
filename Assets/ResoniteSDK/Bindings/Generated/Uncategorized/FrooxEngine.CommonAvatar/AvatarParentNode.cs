
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarParentNode
// Generated on: pátek 13. února 2026 5:52:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarParentNode")]
public partial class AvatarParentNode : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObject

{
    public global::Renderite.Shared.BodyNode Node;
public global::System.Boolean DestroyOnDequip;
public UnityEngine.Vector3 Scale;
public global::System.Int32 EquipOrderPriority;
public global::FrooxEngine.Slot _originalParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("DestroyOnDequip", DestroyOnDequip.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("EquipOrderPriority", EquipOrderPriority.ToResoniteLinkField());
members.Add("_originalParent", new ResoniteLink.Reference() { });
}

}
}
