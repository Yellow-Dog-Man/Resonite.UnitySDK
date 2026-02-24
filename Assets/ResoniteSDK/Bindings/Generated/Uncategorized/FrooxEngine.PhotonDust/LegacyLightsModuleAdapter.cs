
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyLightsModuleAdapter
// Generated on: úterý 24. února 2026 18:20:24
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LegacyLight", LegacyLight.ToResoniteReference(context));
members.Add("ReferenceLight", ReferenceLight.ToResoniteReference(context));
members.Add("LightsModuleEnabled", LightsModuleEnabled.ToResoniteReference(context));
}

}
}
