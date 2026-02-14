
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.NiceTypeName
// Generated on: sobota 14. února 2026 8:58:29
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Utility.NiceTypeName")]
public partial class NiceTypeName : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.String> Type;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> OpenSymbol;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> CloseSymbol;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type.ToResoniteReference(context));
members.Add("OpenSymbol", OpenSymbol.ToResoniteReference(context));
members.Add("CloseSymbol", CloseSymbol.ToResoniteReference(context));
}

}
}
