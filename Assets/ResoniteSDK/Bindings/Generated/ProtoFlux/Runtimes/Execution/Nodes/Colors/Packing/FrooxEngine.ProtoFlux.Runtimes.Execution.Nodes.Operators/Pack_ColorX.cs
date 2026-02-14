
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_ColorX
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_ColorX")]
public partial class Pack_ColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.ColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> R;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> G;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> B;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> A;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile> Profile;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("R", R.ToResoniteReference(context));
members.Add("G", G.ToResoniteReference(context));
members.Add("B", B.ToResoniteReference(context));
members.Add("A", A.ToResoniteReference(context));
members.Add("Profile", Profile.ToResoniteReference(context));
}

}
}
