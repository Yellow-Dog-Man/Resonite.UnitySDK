
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.HSV_ToColor
// Generated on: středa 25. února 2026 16:13:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.HSV_ToColor")]
public partial class HSV_ToColor : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Color>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> H;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> S;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> V;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("H", H.ToResoniteReference(context));
members.Add("S", S.ToResoniteReference(context));
members.Add("V", V.ToResoniteReference(context));
}

}
}
