
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleSettings
// Generated on: čtvrtek 26. února 2026 15:09:13
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleSettings")]
public partial class LocaleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocaleSettings>

{
    public global::System.String PrimaryInterfaceLocaleCode { get => PrimaryInterfaceLocaleCode_Element.Data; set => PrimaryInterfaceLocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PrimaryInterfaceLocaleCode_Element = new();
public global::System.String CultureLocaleCode { get => CultureLocaleCode_Element.Data; set => CultureLocaleCode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CultureLocaleCode_Element = new();
public global::System.Boolean UseImperialUnits { get => UseImperialUnits_Element.Data; set => UseImperialUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseImperialUnits_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PrimaryInterfaceLocaleCode", PrimaryInterfaceLocaleCode_Element.ToLinkField(context));
members.Add("CultureLocaleCode", CultureLocaleCode_Element.ToLinkField(context));
members.Add("UseImperialUnits", UseImperialUnits_Element.ToLinkField(context));
}

}
}
