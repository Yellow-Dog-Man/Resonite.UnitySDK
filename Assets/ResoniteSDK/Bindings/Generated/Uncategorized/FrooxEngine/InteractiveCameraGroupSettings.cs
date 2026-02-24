
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraGroupSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraGroupSettings")]
public partial class InteractiveCameraGroupSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraGroupSettings>

{
    public global::System.Single GroupDetectionRadius;
public global::System.Single GroupLeaveBoundary;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GroupDetectionRadius", GroupDetectionRadius.ToResoniteLinkField());
members.Add("GroupLeaveBoundary", GroupLeaveBoundary.ToResoniteLinkField());
}

}
}
