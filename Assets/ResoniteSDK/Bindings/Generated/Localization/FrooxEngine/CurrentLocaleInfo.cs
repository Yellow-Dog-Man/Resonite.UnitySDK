
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentLocaleInfo
// Generated on: pátek 13. února 2026 5:51:13
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentLocaleInfo")]
public partial class CurrentLocaleInfo : global::FrooxEngine.Component

{
    public global::System.String LocaleCode;
public global::System.String LanguageCode;
public global::System.String NativeLocaleName;
public global::System.String EnglishLocaleName;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LocaleCode", LocaleCode.ToResoniteLinkField());
members.Add("LanguageCode", LanguageCode.ToResoniteLinkField());
members.Add("NativeLocaleName", NativeLocaleName.ToResoniteLinkField());
members.Add("EnglishLocaleName", EnglishLocaleName.ToResoniteLinkField());
}

}
}
