
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticManager
// Generated on: pátek 13. února 2026 5:52:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticManager")]
public partial class HapticManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ICustomInspector

{
    public global::System.Single InjectedBodyPartIntensity;
public global::System.Single InjectedHandIntensity;
public global::System.Single InjectedHeadIntensity;
public global::System.Single InjectedRadiusStartRatio;
public global::System.Single InjectedRadiusEndRatio;
public global::System.Single InjectedRadiusPower;
public global::System.Boolean ShowDebugVisuals;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InjectedBodyPartIntensity", InjectedBodyPartIntensity.ToResoniteLinkField());
members.Add("InjectedHandIntensity", InjectedHandIntensity.ToResoniteLinkField());
members.Add("InjectedHeadIntensity", InjectedHeadIntensity.ToResoniteLinkField());
members.Add("InjectedRadiusStartRatio", InjectedRadiusStartRatio.ToResoniteLinkField());
members.Add("InjectedRadiusEndRatio", InjectedRadiusEndRatio.ToResoniteLinkField());
members.Add("InjectedRadiusPower", InjectedRadiusPower.ToResoniteLinkField());
members.Add("ShowDebugVisuals", ShowDebugVisuals.ToResoniteLinkField());
}

}
}
