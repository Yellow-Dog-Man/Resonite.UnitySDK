
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelaySecondsDouble
// Generated on: pátek 13. února 2026 23:22:29
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelaySecondsDouble")]
public partial class DelaySecondsDouble : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.DelayTime

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Duration;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Duration", new ResoniteLink.Reference() { });
}

}
}
