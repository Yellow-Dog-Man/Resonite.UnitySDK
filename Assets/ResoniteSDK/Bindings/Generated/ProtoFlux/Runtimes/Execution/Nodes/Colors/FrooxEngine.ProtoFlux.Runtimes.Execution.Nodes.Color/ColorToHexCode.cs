
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode")]
public partial class ColorToHexCode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> Color;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShortForm;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeAlpha;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Prefix;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", new ResoniteLink.Reference() { });
members.Add("ShortForm", new ResoniteLink.Reference() { });
members.Add("IncludeAlpha", new ResoniteLink.Reference() { });
members.Add("Prefix", new ResoniteLink.Reference() { });
}

}
}
