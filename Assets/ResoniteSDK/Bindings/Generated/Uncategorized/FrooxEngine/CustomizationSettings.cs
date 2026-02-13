
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CustomizationSettings
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CustomizationSettings")]
public partial class CustomizationSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.CustomizationSettings>

{
    public global::System.Boolean UserInterfaceEditMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UserInterfaceEditMode", UserInterfaceEditMode.ToResoniteLinkField());
}

}
}
