
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentLocaleInfo
// Generated on: čtvrtek 19. února 2026 7:58:59
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentLocaleInfo")]
public partial class CurrentLocaleInfo : global::FrooxEngine.Component

{
    public global::System.String LocaleCode;
public global::System.String LanguageCode;
public global::System.String NativeLocaleName;
public global::System.String EnglishLocaleName;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocaleCode", LocaleCode.ToResoniteLinkField());
members.Add("LanguageCode", LanguageCode.ToResoniteLinkField());
members.Add("NativeLocaleName", NativeLocaleName.ToResoniteLinkField());
members.Add("EnglishLocaleName", EnglishLocaleName.ToResoniteLinkField());
}

}
}
