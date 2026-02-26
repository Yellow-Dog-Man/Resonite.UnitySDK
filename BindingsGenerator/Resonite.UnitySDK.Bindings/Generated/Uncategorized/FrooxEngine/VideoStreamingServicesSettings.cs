
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoStreamingServicesSettings
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoStreamingServicesSettings")]
public partial class VideoStreamingServicesSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.VideoStreamingServicesSettings>

{
    public global::NYoutubeDL.Options.CookiesBrowser UseCookiesFromBrowser { get => UseCookiesFromBrowser_Element.Data; set => UseCookiesFromBrowser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::NYoutubeDL.Options.CookiesBrowser>, global::NYoutubeDL.Options.CookiesBrowser> UseCookiesFromBrowser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseCookiesFromBrowser", UseCookiesFromBrowser_Element.Data.ToResoniteLinkField());
}

}
}
