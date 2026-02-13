
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Utility.DelayBase<>
// Generated on: pátek 13. února 2026 23:22:59
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Utility
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Utility.DelayBase<>")]
public abstract partial class DelayBase<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UpdateBase
	

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> DelaySeconds;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DelaySeconds", new ResoniteLink.Reference() { });
}

}
}
