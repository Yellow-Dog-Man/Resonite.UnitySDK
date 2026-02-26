
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNodeAssigner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNodeAssigner")]
public partial class AvatarNodeAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::Renderite.Shared.BodyNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> Node_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>>, global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>>, global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>>> Targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkField(context));
members.Add("Targets", Targets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
