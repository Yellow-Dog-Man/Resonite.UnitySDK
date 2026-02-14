
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.HSL_ToColorX
// Generated on: sobota 14. února 2026 8:57:48
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.HSL_ToColorX")]
public partial class HSL_ToColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.ColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> H;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> S;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> L;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile> TargetProfile;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("H", H.ToResoniteReference(context));
members.Add("S", S.ToResoniteReference(context));
members.Add("L", L.ToResoniteReference(context));
members.Add("TargetProfile", TargetProfile.ToResoniteReference(context));
}

}
}
