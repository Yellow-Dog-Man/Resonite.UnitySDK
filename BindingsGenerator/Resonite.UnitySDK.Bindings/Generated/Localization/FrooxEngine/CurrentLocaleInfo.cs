
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurrentLocaleInfo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurrentLocaleInfo")]
public partial class CurrentLocaleInfo : global::FrooxEngine.Component

{
    public global::System.String LocaleCode { get => LocaleCode_Element.Data; set => LocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LocaleCode_Element = new();
public global::System.String LanguageCode { get => LanguageCode_Element.Data; set => LanguageCode_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LanguageCode_Element = new();
public global::System.String NativeLocaleName { get => NativeLocaleName_Element.Data; set => NativeLocaleName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> NativeLocaleName_Element = new();
public global::System.String EnglishLocaleName { get => EnglishLocaleName_Element.Data; set => EnglishLocaleName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> EnglishLocaleName_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocaleCode", LocaleCode_Element.ToLinkField(context));
members.Add("LanguageCode", LanguageCode_Element.ToLinkField(context));
members.Add("NativeLocaleName", NativeLocaleName_Element.ToLinkField(context));
members.Add("EnglishLocaleName", EnglishLocaleName_Element.ToLinkField(context));
}

}
}
