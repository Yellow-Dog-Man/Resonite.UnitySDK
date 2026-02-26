
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserLoginManager
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean IsLoggedIn { get => IsLoggedIn_Element.Data; set => IsLoggedIn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoggedIn_Element = new();
public global::System.Boolean IsLoggingOut { get => IsLoggingOut_Element.Data; set => IsLoggingOut_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoggingOut_Element = new();
public global::System.String CurrentUsername { get => CurrentUsername_Element.Data; set => CurrentUsername_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CurrentUsername_Element = new();
public global::System.String CurrentUserId { get => CurrentUserId_Element.Data; set => CurrentUserId_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CurrentUserId_Element = new();
public global::System.String CurrentAccountType { get => CurrentAccountType_Element.Data; set => CurrentAccountType_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CurrentAccountType_Element = new();
public global::System.Nullable<UnityEngine.ColorX> CurrentAccountColorOverride { get => CurrentAccountColorOverride_Element.Data; set => CurrentAccountColorOverride_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<UnityEngine.ColorX>>, global::System.Nullable<UnityEngine.ColorX>> CurrentAccountColorOverride_Element = new();
public System.Uri CurrentProfileIcon { get => CurrentProfileIcon_Element.Data; set => CurrentProfileIcon_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> CurrentProfileIcon_Element = new();
public global::FrooxEngine.UIX.Button LoginLogoutButton { get => LoginLogoutButton_Element.Data; set => LoginLogoutButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> LoginLogoutButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLoggedIn", IsLoggedIn_Element.ToLinkField(context));
members.Add("IsLoggingOut", IsLoggingOut_Element.ToLinkField(context));
members.Add("CurrentUsername", CurrentUsername_Element.ToLinkField(context));
members.Add("CurrentUserId", CurrentUserId_Element.ToLinkField(context));
members.Add("CurrentAccountType", CurrentAccountType_Element.ToLinkField(context));
members.Add("CurrentAccountColorOverride", CurrentAccountColorOverride_Element.ToLinkField(context));
members.Add("CurrentProfileIcon", CurrentProfileIcon_Element.ToLinkField(context));
members.Add("LoginLogoutButton", LoginLogoutButton_Element.ToLinkReference(context));
}

}
}
