
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleSettings
// Generated on: středa 25. února 2026 16:14:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleSettings")]
public partial class LocaleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocaleSettings>

{
    public global::System.String PrimaryInterfaceLocaleCode;
public global::System.String CultureLocaleCode;
public global::System.Boolean UseImperialUnits;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PrimaryInterfaceLocaleCode", PrimaryInterfaceLocaleCode.ToResoniteLinkField());
members.Add("CultureLocaleCode", CultureLocaleCode.ToResoniteLinkField());
members.Add("UseImperialUnits", UseImperialUnits.ToResoniteLinkField());
}

}
}
