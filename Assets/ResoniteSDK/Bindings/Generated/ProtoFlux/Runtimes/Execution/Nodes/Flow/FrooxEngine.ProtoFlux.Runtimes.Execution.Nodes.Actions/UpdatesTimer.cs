
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UpdatesTimer
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UpdatesTimer")]
public partial class UpdatesTimer : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnUpdate;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Interval;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnUpdate", new ResoniteLink.Reference() { });
members.Add("Interval", new ResoniteLink.Reference() { });
}

}
}
