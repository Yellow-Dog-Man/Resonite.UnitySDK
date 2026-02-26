
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.ReadValueCloudVariable<>
// Generated on: čtvrtek 26. února 2026 12:28:00
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.ReadValueCloudVariable<>")]
public partial class ReadValueCloudVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.ReadCloudVariable<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Value = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToLinkEmpty(context));
}

}
}
