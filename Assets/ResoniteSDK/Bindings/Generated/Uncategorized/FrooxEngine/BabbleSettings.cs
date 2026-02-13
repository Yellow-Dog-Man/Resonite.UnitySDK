
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BabbleSettings
// Generated on: pátek 13. února 2026 5:52:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BabbleSettings")]
public partial class BabbleSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.BabbleSettings>

{
    public global::System.Int32 OSC_DataPort;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OSC_DataPort", OSC_DataPort.ToResoniteLinkField());
}

}
}
