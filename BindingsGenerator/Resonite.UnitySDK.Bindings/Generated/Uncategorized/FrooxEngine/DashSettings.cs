
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DashSettings
// Generated on: středa 25. února 2026 16:14:36
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DashSettings")]
public partial class DashSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DashSettings>

{
    public global::System.Single DashCurvature;
public global::System.Single OpenCloseSpeed;
public global::System.Boolean AllowReplacingSettings;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DashCurvature", DashCurvature.ToResoniteLinkField());
members.Add("OpenCloseSpeed", OpenCloseSpeed.ToResoniteLinkField());
members.Add("AllowReplacingSettings", AllowReplacingSettings.ToResoniteLinkField());
}

}
}
