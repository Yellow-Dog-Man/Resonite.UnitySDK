
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNodeAssigner
// Generated on: středa 25. února 2026 16:14:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNodeAssigner")]
public partial class AvatarNodeAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::Renderite.Shared.BodyNode Node;
public System.Collections.Generic.List<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>> Targets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
