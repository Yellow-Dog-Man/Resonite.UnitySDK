
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_0000<,>
// Generated on: čtvrtek 26. února 2026 12:27:16
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncObjectFunctionProxy_0000<,>")]
public partial class SyncObjectFunctionProxy_0000<T0,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,TResult>>
	
	where T0 : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T0> Arg0 { get => Arg0_Element.Data; set => Arg0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T0>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T0>> Arg0_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0_Element.ToLinkReference(context));
members.Add("Result", Result.ToLinkEmpty(context));
}

}
}
