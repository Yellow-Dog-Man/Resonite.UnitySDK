
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.Slerp_doubleQ
// Generated on: sobota 14. února 2026 8:58:07
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.Slerp_doubleQ")]
public partial class Slerp_doubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.QuaternionDouble>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> To;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("From", From.ToResoniteReference(context));
members.Add("To", To.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteReference(context));
}

}
}
