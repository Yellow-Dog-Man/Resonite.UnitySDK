
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserLoginManager
// Generated on: pátek 13. února 2026 23:21:37
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserLoginManager")]
public partial class UserLoginManager : global::FrooxEngine.Component

{
    public global::System.Boolean IsLoggedIn;
public global::System.Boolean IsLoggingOut;
public global::System.String CurrentUsername;
public global::System.String CurrentUserId;
public global::System.String CurrentAccountType;
public global::System.Nullable<UnityEngine.ColorX> CurrentAccountColorOverride;
public System.Uri CurrentProfileIcon;
public global::FrooxEngine.UIX.Button LoginLogoutButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsLoggedIn", IsLoggedIn.ToResoniteLinkField());
members.Add("IsLoggingOut", IsLoggingOut.ToResoniteLinkField());
members.Add("CurrentUsername", CurrentUsername.ToResoniteLinkField());
members.Add("CurrentUserId", CurrentUserId.ToResoniteLinkField());
members.Add("CurrentAccountType", CurrentAccountType.ToResoniteLinkField());
members.Add("CurrentAccountColorOverride", CurrentAccountColorOverride.ToResoniteLinkField());
members.Add("CurrentProfileIcon", CurrentProfileIcon.ToResoniteLinkField());
members.Add("LoginLogoutButton", new ResoniteLink.Reference() { });
}

}
}
