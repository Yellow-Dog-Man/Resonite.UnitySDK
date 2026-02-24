
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPositioningSettings
// Generated on: úterý 24. února 2026 18:20:23
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPositioningSettings")]
public partial class InteractiveCameraPositioningSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPositioningSettings>

{
    public global::System.Boolean AvoidOcclusion;
public global::System.Boolean KeepInWorldSpace;
public global::System.Boolean MovementWobble;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AvoidOcclusion", AvoidOcclusion.ToResoniteLinkField());
members.Add("KeepInWorldSpace", KeepInWorldSpace.ToResoniteLinkField());
members.Add("MovementWobble", MovementWobble.ToResoniteLinkField());
}

}
}
