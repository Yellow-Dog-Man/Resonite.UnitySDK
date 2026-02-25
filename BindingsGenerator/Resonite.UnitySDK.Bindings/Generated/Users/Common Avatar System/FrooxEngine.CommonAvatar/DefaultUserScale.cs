
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.DefaultUserScale
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.DefaultUserScale")]
public partial class DefaultUserScale : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Boolean SetOnEquip;
public global::System.Single DefaultScale;
public global::FrooxEngine.User _activeUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetOnEquip", SetOnEquip.ToResoniteLinkField());
members.Add("DefaultScale", DefaultScale.ToResoniteLinkField());
members.Add("_activeUser", _activeUser.ToResoniteReference(context));
}

}
}
