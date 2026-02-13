
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PerformanceMetrics
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PerformanceMetrics")]
public partial class PerformanceMetrics : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef User;
public global::System.Single FPS;
public global::System.Single ImmediateFPS;
public global::System.Single RenderTime;
public global::System.Single TotalEngineUpdateTime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers() });
members.Add("FPS", FPS.ToResoniteLinkField());
members.Add("ImmediateFPS", ImmediateFPS.ToResoniteLinkField());
members.Add("RenderTime", RenderTime.ToResoniteLinkField());
members.Add("TotalEngineUpdateTime", TotalEngineUpdateTime.ToResoniteLinkField());
}

}
}
