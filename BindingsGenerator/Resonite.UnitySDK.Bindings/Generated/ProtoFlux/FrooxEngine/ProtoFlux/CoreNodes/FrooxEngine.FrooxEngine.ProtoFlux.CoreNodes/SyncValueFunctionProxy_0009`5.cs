
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0009<,,,,>
// Generated on: čtvrtek 26. února 2026 15:08:24
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_0009<,,,,>")]
public partial class SyncValueFunctionProxy_0009<T0,T1,T2,T3,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,T1,T2,T3,TResult>>
	where TResult : struct
	
	where T2 : struct
	where T1 : struct
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0 { get => Arg0_Element.Data; set => Arg0_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>> Arg0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T1> Arg1 { get => Arg1_Element.Data; set => Arg1_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>> Arg1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T2> Arg2 { get => Arg2_Element.Data; set => Arg2_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T2>> Arg2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3 { get => Arg3_Element.Data; set => Arg3_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>> Arg3_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0_Element.ToLinkReference(context));
members.Add("Arg1", Arg1_Element.ToLinkReference(context));
members.Add("Arg2", Arg2_Element.ToLinkReference(context));
members.Add("Arg3", Arg3_Element.ToLinkReference(context));
members.Add("Result", Result.ToLinkEmpty(context));
}

}
}
