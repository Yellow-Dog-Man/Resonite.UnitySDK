
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver
// Generated on: pátek 13. února 2026 23:22:30
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver")]
public partial class AsyncDynamicImpulseReceiver : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver.Proxy>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String> Tag;
public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tag", new ResoniteLink.Reference() { });
members.Add("OnTriggered", new ResoniteLink.Reference() { });
}

}
}
