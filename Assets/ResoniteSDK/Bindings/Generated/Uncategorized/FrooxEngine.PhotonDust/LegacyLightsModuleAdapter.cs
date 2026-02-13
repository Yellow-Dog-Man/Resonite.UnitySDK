
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyLightsModuleAdapter
// Generated on: pátek 13. února 2026 5:52:33
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyLightsModuleAdapter")]
public partial class LegacyLightsModuleAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.Light LegacyLight;
public global::FrooxEngine.Light ReferenceLight;
public global::FrooxEngine.IField<global::System.Boolean> LightsModuleEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LegacyLight", new ResoniteLink.Reference() { });
members.Add("ReferenceLight", new ResoniteLink.Reference() { });
members.Add("LightsModuleEnabled", new ResoniteLink.Reference() { });
}

}
}
