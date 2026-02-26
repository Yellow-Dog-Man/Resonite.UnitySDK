
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudUserInfo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudUserInfo")]
public partial class CloudUserInfo : global::FrooxEngine.Component

{
    public global::System.String UserId { get => UserId_Element.Data; set => UserId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> UserId_Element = new();
public global::System.Boolean IsLoaded { get => IsLoaded_Element.Data; set => IsLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoaded_Element = new();
public global::System.String Username { get => Username_Element.Data; set => Username_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Username_Element = new();
public global::System.DateTime RegistrationDate { get => RegistrationDate_Element.Data; set => RegistrationDate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> RegistrationDate_Element = new();
public global::System.DateTime OriginalRegistrationDate { get => OriginalRegistrationDate_Element.Data; set => OriginalRegistrationDate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> OriginalRegistrationDate_Element = new();
public System.Uri IconURL { get => IconURL_Element.Data; set => IconURL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> IconURL_Element = new();
public global::System.Boolean IsContact { get => IsContact_Element.Data; set => IsContact_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsContact_Element = new();
public global::System.String _loadedUserId { get => _loadedUserId_Element.Data; set => _loadedUserId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _loadedUserId_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserId", UserId_Element.ToLinkField(context));
members.Add("IsLoaded", IsLoaded_Element.ToLinkField(context));
members.Add("Username", Username_Element.ToLinkField(context));
members.Add("RegistrationDate", RegistrationDate_Element.ToLinkField(context));
members.Add("OriginalRegistrationDate", OriginalRegistrationDate_Element.ToLinkField(context));
members.Add("IconURL", IconURL_Element.ToLinkField(context));
members.Add("IsContact", IsContact_Element.ToLinkField(context));
members.Add("_loadedUserId", _loadedUserId_Element.ToLinkField(context));
}

}
}
