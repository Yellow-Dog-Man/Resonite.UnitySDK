
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ArmHapticPointMapper
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ArmHapticPointMapper")]
public partial class ArmHapticPointMapper : global::FrooxEngine.LimbHapticPointMapper<global::FrooxEngine.ArmHapticPosition>

{
    public global::System.Single HandRadius;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HandRadius", HandRadius.ToResoniteLinkField());
}

}
}
