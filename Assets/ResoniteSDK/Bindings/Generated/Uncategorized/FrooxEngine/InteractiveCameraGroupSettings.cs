
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraGroupSettings
// Generated on: pátek 13. února 2026 5:52:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraGroupSettings")]
public partial class InteractiveCameraGroupSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraGroupSettings>

{
    public global::System.Single GroupDetectionRadius;
public global::System.Single GroupLeaveBoundary;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("GroupDetectionRadius", GroupDetectionRadius.ToResoniteLinkField());
members.Add("GroupLeaveBoundary", GroupLeaveBoundary.ToResoniteLinkField());
}

}
}
