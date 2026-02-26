
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarParentNode
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarParentNode")]
public partial class AvatarParentNode : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObject

{
    public global::Renderite.Shared.BodyNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> Node_Element = new();
public global::System.Boolean DestroyOnDequip { get => DestroyOnDequip_Element.Data; set => DestroyOnDequip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DestroyOnDequip_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public global::System.Int32 EquipOrderPriority { get => EquipOrderPriority_Element.Data; set => EquipOrderPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EquipOrderPriority_Element = new();
public global::FrooxEngine.Slot _originalParent { get => _originalParent_Element.Data; set => _originalParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _originalParent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.Data.ToResoniteLinkField());
members.Add("DestroyOnDequip", DestroyOnDequip_Element.Data.ToResoniteLinkField());
members.Add("Scale", Scale_Element.Data.ToResoniteLinkField());
members.Add("EquipOrderPriority", EquipOrderPriority_Element.Data.ToResoniteLinkField());
members.Add("_originalParent", _originalParent_Element.Data.ToResoniteReference(context));
}

}
}
