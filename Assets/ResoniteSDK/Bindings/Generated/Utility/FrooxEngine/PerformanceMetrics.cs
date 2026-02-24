
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PerformanceMetrics
// Generated on: úterý 24. února 2026 18:20:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PerformanceMetrics")]
public partial class PerformanceMetrics : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef User;
public global::System.Single FPS;
public global::System.Single ImmediateFPS;
public global::System.Single RenderTime;
public global::System.Single TotalEngineUpdateTime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("FPS", FPS.ToResoniteLinkField());
members.Add("ImmediateFPS", ImmediateFPS.ToResoniteLinkField());
members.Add("RenderTime", RenderTime.ToResoniteLinkField());
members.Add("TotalEngineUpdateTime", TotalEngineUpdateTime.ToResoniteLinkField());
}

}
}
