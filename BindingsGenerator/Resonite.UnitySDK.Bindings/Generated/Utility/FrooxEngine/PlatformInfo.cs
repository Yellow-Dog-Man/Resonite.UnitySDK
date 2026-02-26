
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformInfo
// Generated on: čtvrtek 26. února 2026 10:04:50
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformInfo")]
public partial class PlatformInfo : global::FrooxEngine.Component

{
    public global::System.String PlatformName { get => PlatformName_Element.Data; set => PlatformName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> PlatformName_Element = new();
public global::System.String ShortNamePrefix { get => ShortNamePrefix_Element.Data; set => ShortNamePrefix_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> ShortNamePrefix_Element = new();
public global::System.String Abbreviation { get => Abbreviation_Element.Data; set => Abbreviation_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> Abbreviation_Element = new();
public global::System.String Domain { get => Domain_Element.Data; set => Domain_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> Domain_Element = new();
public global::System.String Email { get => Email_Element.Data; set => Email_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> Email_Element = new();
public global::System.String DiscordInviteUrl { get => DiscordInviteUrl_Element.Data; set => DiscordInviteUrl_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> DiscordInviteUrl_Element = new();
public global::System.String PoliciesPage { get => PoliciesPage_Element.Data; set => PoliciesPage_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> PoliciesPage_Element = new();
public global::System.String PatreonUrl { get => PatreonUrl_Element.Data; set => PatreonUrl_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> PatreonUrl_Element = new();
public global::System.String GitHubProfile { get => GitHubProfile_Element.Data; set => GitHubProfile_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> GitHubProfile_Element = new();
public global::System.String GitHubIssuesRepository { get => GitHubIssuesRepository_Element.Data; set => GitHubIssuesRepository_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> GitHubIssuesRepository_Element = new();
public global::System.String AuthScheme { get => AuthScheme_Element.Data; set => AuthScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> AuthScheme_Element = new();
public global::System.String AppScheme { get => AppScheme_Element.Data; set => AppScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> AppScheme_Element = new();
public global::System.String DBScheme { get => DBScheme_Element.Data; set => DBScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> DBScheme_Element = new();
public global::System.String SessionScheme { get => SessionScheme_Element.Data; set => SessionScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> SessionScheme_Element = new();
public global::System.String RecordScheme { get => RecordScheme_Element.Data; set => RecordScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> RecordScheme_Element = new();
public global::System.String UserSessionScheme { get => UserSessionScheme_Element.Data; set => UserSessionScheme_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> UserSessionScheme_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PlatformName", PlatformName_Element.Data.ToResoniteLinkField());
members.Add("ShortNamePrefix", ShortNamePrefix_Element.Data.ToResoniteLinkField());
members.Add("Abbreviation", Abbreviation_Element.Data.ToResoniteLinkField());
members.Add("Domain", Domain_Element.Data.ToResoniteLinkField());
members.Add("Email", Email_Element.Data.ToResoniteLinkField());
members.Add("DiscordInviteUrl", DiscordInviteUrl_Element.Data.ToResoniteLinkField());
members.Add("PoliciesPage", PoliciesPage_Element.Data.ToResoniteLinkField());
members.Add("PatreonUrl", PatreonUrl_Element.Data.ToResoniteLinkField());
members.Add("GitHubProfile", GitHubProfile_Element.Data.ToResoniteLinkField());
members.Add("GitHubIssuesRepository", GitHubIssuesRepository_Element.Data.ToResoniteLinkField());
members.Add("AuthScheme", AuthScheme_Element.Data.ToResoniteLinkField());
members.Add("AppScheme", AppScheme_Element.Data.ToResoniteLinkField());
members.Add("DBScheme", DBScheme_Element.Data.ToResoniteLinkField());
members.Add("SessionScheme", SessionScheme_Element.Data.ToResoniteLinkField());
members.Add("RecordScheme", RecordScheme_Element.Data.ToResoniteLinkField());
members.Add("UserSessionScheme", UserSessionScheme_Element.Data.ToResoniteLinkField());
}

}
}
