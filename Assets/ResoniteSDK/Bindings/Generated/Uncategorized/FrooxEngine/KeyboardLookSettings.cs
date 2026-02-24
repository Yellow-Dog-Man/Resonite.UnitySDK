
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.KeyboardLookSettings
// Generated on: úterý 24. února 2026 18:20:24
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.KeyboardLookSettings")]
public partial class KeyboardLookSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.KeyboardLookSettings>

{
    public global::System.Boolean LookEnabled;
public global::System.Single HorizontalSpeed;
public global::System.Single VerticalSpeed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LookEnabled", LookEnabled.ToResoniteLinkField());
members.Add("HorizontalSpeed", HorizontalSpeed.ToResoniteLinkField());
members.Add("VerticalSpeed", VerticalSpeed.ToResoniteLinkField());
}

}
}
