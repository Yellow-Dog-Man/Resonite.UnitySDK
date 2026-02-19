
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInterfaceEditModeSync
// Generated on: čtvrtek 19. února 2026 8:00:33
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInterfaceEditModeSync")]
public partial class UserInterfaceEditModeSync : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef TargetUser;
public global::System.Boolean EditModeActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers(context) });
members.Add("EditModeActive", EditModeActive.ToResoniteLinkField());
}

}
}
