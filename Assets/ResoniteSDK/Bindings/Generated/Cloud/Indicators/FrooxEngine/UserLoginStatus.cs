
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserLoginStatus
// Generated on: sobota 14. února 2026 8:57:03
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserLoginStatus")]
public partial class UserLoginStatus : global::FrooxEngine.Component

{
    public global::System.Boolean IsLoggedIn;
public global::System.String LoggedUserId;
public global::System.String LoggedUsername;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLoggedIn", IsLoggedIn.ToResoniteLinkField());
members.Add("LoggedUserId", LoggedUserId.ToResoniteLinkField());
members.Add("LoggedUsername", LoggedUsername.ToResoniteLinkField());
}

}
}
