
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.KeyboardLookSettings
// Generated on: pátek 13. února 2026 23:23:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.KeyboardLookSettings")]
public partial class KeyboardLookSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.KeyboardLookSettings>

{
    public global::System.Boolean LookEnabled;
public global::System.Single HorizontalSpeed;
public global::System.Single VerticalSpeed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LookEnabled", LookEnabled.ToResoniteLinkField());
members.Add("HorizontalSpeed", HorizontalSpeed.ToResoniteLinkField());
members.Add("VerticalSpeed", VerticalSpeed.ToResoniteLinkField());
}

}
}
