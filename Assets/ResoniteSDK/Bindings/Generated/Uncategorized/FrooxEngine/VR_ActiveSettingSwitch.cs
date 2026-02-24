
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch
// Generated on: úterý 24. února 2026 18:20:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch")]
public partial class VR_ActiveSettingSwitch : global::FrooxEngine.SettingSwitch<global::FrooxEngine.VR_ActiveSetttingSwitchSource>

{
    public global::System.Boolean VR_Active;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VR_Active", VR_Active.ToResoniteLinkField());
}

}
}
