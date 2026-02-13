
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocaleSettings
// Generated on: pátek 13. února 2026 5:52:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocaleSettings")]
public partial class LocaleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocaleSettings>

{
    public global::System.String PrimaryInterfaceLocaleCode;
public global::System.String CultureLocaleCode;
public global::System.Boolean UseImperialUnits;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PrimaryInterfaceLocaleCode", PrimaryInterfaceLocaleCode.ToResoniteLinkField());
members.Add("CultureLocaleCode", CultureLocaleCode.ToResoniteLinkField());
members.Add("UseImperialUnits", UseImperialUnits.ToResoniteLinkField());
}

}
}
