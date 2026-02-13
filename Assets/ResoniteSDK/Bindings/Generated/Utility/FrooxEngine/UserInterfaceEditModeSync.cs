
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInterfaceEditModeSync
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers() });
members.Add("EditModeActive", EditModeActive.ToResoniteLinkField());
}

}
}
