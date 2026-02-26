
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset")]
public partial class AvatarNeckOffset : global::FrooxEngine.UserRootComponent, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.INeckOffsetSource

{
    public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("_activeUser", _activeUser_Element.ToLinkReference(context));
}

}
}
