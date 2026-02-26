
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4
// Generated on: čtvrtek 26. února 2026 15:08:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Pack_Sbyte4")]
public partial class Pack_Sbyte4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4Sbyte>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> X { get => X_Element.Data; set => X_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>> X_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>> Y_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Z { get => Z_Element.Data; set => Z_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>> Z_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> W { get => W_Element.Data; set => W_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte>> W_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X_Element.ToLinkReference(context));
members.Add("Y", Y_Element.ToLinkReference(context));
members.Add("Z", Z_Element.ToLinkReference(context));
members.Add("W", W_Element.ToLinkReference(context));
}

}
}
