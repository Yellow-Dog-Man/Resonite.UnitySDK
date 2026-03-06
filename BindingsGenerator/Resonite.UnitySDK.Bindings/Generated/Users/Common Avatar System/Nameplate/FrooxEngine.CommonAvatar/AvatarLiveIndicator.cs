
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarLiveIndicator
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarLiveIndicator")]
public partial class AvatarLiveIndicator : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Boolean IsLive { get => IsLive_Element.Data; set => IsLive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLive_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLive", IsLive_Element.ToLinkField(context));
members.Add("_activeUser", _activeUser_Element.ToLinkReference(context));
}

}
}
