
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserLoginStatus
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Boolean IsLoggedIn { get => IsLoggedIn_Element.Data; set => IsLoggedIn_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoggedIn_Element = new();
public global::System.String LoggedUserId { get => LoggedUserId_Element.Data; set => LoggedUserId_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LoggedUserId_Element = new();
public global::System.String LoggedUsername { get => LoggedUsername_Element.Data; set => LoggedUsername_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LoggedUsername_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLoggedIn", IsLoggedIn_Element.ToLinkField(context));
members.Add("LoggedUserId", LoggedUserId_Element.ToLinkField(context));
members.Add("LoggedUsername", LoggedUsername_Element.ToLinkField(context));
}

}
}
