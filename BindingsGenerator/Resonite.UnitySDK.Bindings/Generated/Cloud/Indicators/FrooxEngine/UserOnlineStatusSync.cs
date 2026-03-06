
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserOnlineStatusSync
// Generated on: pátek 6. března 2026 14:18:06
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserOnlineStatusSync")]
public partial class UserOnlineStatusSync : global::FrooxEngine.Component

{
    public global::SkyFrost.Base.OnlineStatus OnlineStatus { get => OnlineStatus_Element.Data; set => OnlineStatus_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.OnlineStatus>, global::SkyFrost.Base.OnlineStatus> OnlineStatus_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlineStatus", OnlineStatus_Element.ToLinkField(context));
}

}
}
