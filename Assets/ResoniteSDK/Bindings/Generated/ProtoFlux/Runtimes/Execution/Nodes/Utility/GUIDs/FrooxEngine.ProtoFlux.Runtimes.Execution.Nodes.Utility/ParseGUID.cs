
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.ParseGUID
// Generated on: pátek 13. února 2026 23:23:00
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.ParseGUID")]
public partial class ParseGUID : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Guid> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Parsed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Str", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("Parsed", new ResoniteLink.EmptyElement());
}

}
}
