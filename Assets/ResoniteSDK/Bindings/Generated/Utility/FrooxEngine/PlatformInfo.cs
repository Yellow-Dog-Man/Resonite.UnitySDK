
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformInfo
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformInfo")]
public partial class PlatformInfo : global::FrooxEngine.Component

{
    public global::System.String PlatformName;
public global::System.String ShortNamePrefix;
public global::System.String Abbreviation;
public global::System.String Domain;
public global::System.String Email;
public global::System.String DiscordInviteUrl;
public global::System.String PoliciesPage;
public global::System.String PatreonUrl;
public global::System.String GitHubProfile;
public global::System.String GitHubIssuesRepository;
public global::System.String AuthScheme;
public global::System.String AppScheme;
public global::System.String DBScheme;
public global::System.String SessionScheme;
public global::System.String RecordScheme;
public global::System.String UserSessionScheme;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PlatformName", PlatformName.ToResoniteLinkField());
members.Add("ShortNamePrefix", ShortNamePrefix.ToResoniteLinkField());
members.Add("Abbreviation", Abbreviation.ToResoniteLinkField());
members.Add("Domain", Domain.ToResoniteLinkField());
members.Add("Email", Email.ToResoniteLinkField());
members.Add("DiscordInviteUrl", DiscordInviteUrl.ToResoniteLinkField());
members.Add("PoliciesPage", PoliciesPage.ToResoniteLinkField());
members.Add("PatreonUrl", PatreonUrl.ToResoniteLinkField());
members.Add("GitHubProfile", GitHubProfile.ToResoniteLinkField());
members.Add("GitHubIssuesRepository", GitHubIssuesRepository.ToResoniteLinkField());
members.Add("AuthScheme", AuthScheme.ToResoniteLinkField());
members.Add("AppScheme", AppScheme.ToResoniteLinkField());
members.Add("DBScheme", DBScheme.ToResoniteLinkField());
members.Add("SessionScheme", SessionScheme.ToResoniteLinkField());
members.Add("RecordScheme", RecordScheme.ToResoniteLinkField());
members.Add("UserSessionScheme", UserSessionScheme.ToResoniteLinkField());
}

}
}
