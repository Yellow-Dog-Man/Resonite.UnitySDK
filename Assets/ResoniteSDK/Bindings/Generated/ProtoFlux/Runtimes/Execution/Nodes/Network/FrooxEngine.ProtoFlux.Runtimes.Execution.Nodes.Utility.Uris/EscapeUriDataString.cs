
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.Uris.EscapeUriDataString
// Generated on: pátek 13. února 2026 23:22:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.Uris
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.Uris.EscapeUriDataString")]
public partial class EscapeUriDataString : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> String;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("String", new ResoniteLink.Reference() { });
}

}
}
