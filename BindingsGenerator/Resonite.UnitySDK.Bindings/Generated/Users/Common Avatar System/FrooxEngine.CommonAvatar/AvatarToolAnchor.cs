
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarToolAnchor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarToolAnchor")]
public partial class AvatarToolAnchor : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.CommonAvatar.AvatarToolAnchor.Point AnchorPoint { get => AnchorPoint_Element.Data; set => AnchorPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.AvatarToolAnchor.Point>, global::FrooxEngine.CommonAvatar.AvatarToolAnchor.Point> AnchorPoint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorPoint", AnchorPoint_Element.ToLinkField(context));
}

}
}
