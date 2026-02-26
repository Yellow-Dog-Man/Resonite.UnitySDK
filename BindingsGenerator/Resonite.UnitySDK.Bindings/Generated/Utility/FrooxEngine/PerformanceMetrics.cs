
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PerformanceMetrics
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UserRef User = new();
public global::System.Single FPS { get => FPS_Element.Data; set => FPS_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FPS_Element = new();
public global::System.Single ImmediateFPS { get => ImmediateFPS_Element.Data; set => ImmediateFPS_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ImmediateFPS_Element = new();
public global::System.Single RenderTime { get => RenderTime_Element.Data; set => RenderTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RenderTime_Element = new();
public global::System.Single TotalEngineUpdateTime { get => TotalEngineUpdateTime_Element.Data; set => TotalEngineUpdateTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TotalEngineUpdateTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToLinkSyncObject(context));
members.Add("FPS", FPS_Element.ToLinkField(context));
members.Add("ImmediateFPS", ImmediateFPS_Element.ToLinkField(context));
members.Add("RenderTime", RenderTime_Element.ToLinkField(context));
members.Add("TotalEngineUpdateTime", TotalEngineUpdateTime_Element.ToLinkField(context));
}

}
}
