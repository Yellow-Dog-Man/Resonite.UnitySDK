
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleAuthorsInfo
// Generated on: čtvrtek 26. února 2026 12:26:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleAuthorsInfo")]
public partial class LocaleAuthorsInfo : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource> Locale { get => Locale_Element.Data; set => Locale_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.LocaleResource>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.LocaleResource>> Locale_Element = new();
public global::System.String CreditsString { get => CreditsString_Element.Data; set => CreditsString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CreditsString_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Locale", Locale_Element.ToLinkReference(context));
members.Add("CreditsString", CreditsString_Element.ToLinkField(context));
}

}
}
