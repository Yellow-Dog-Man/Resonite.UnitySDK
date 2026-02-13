
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch
// Generated on: pátek 13. února 2026 23:23:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch")]
public partial class VR_ActiveSettingSwitch : global::FrooxEngine.SettingSwitch<global::FrooxEngine.VR_ActiveSetttingSwitchSource>

{
    public global::System.Boolean VR_Active;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VR_Active", VR_Active.ToResoniteLinkField());
}

}
}
