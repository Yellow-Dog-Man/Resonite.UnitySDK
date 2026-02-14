
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudUserInfo
// Generated on: sobota 14. února 2026 8:57:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudUserInfo")]
public partial class CloudUserInfo : global::FrooxEngine.Component

{
    public global::System.String UserId;
public global::System.Boolean IsLoaded;
public global::System.String Username;
public global::System.DateTime RegistrationDate;
public global::System.DateTime OriginalRegistrationDate;
public System.Uri IconURL;
public global::System.Boolean IsContact;
public global::System.String _loadedUserId;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserId", UserId.ToResoniteLinkField());
members.Add("IsLoaded", IsLoaded.ToResoniteLinkField());
members.Add("Username", Username.ToResoniteLinkField());
members.Add("RegistrationDate", RegistrationDate.ToResoniteLinkField());
members.Add("OriginalRegistrationDate", OriginalRegistrationDate.ToResoniteLinkField());
members.Add("IconURL", IconURL.ToResoniteLinkField());
members.Add("IsContact", IsContact.ToResoniteLinkField());
members.Add("_loadedUserId", _loadedUserId.ToResoniteLinkField());
}

}
}
