
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncValueFunctionProxy_0007<,,,>
// Generated on: čtvrtek 26. února 2026 10:03:50
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncValueFunctionProxy_0007<,,,>")]
public partial class AsyncValueFunctionProxy_0007<T0,T1,T2,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,T2,global::System.Threading.Tasks.Task<TResult>>>
	where TResult : struct
	
	
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0 { get => Arg0_Element.Data; set => Arg0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>> Arg0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1 { get => Arg1_Element.Data; set => Arg1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1>> Arg1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2 { get => Arg2_Element.Data; set => Arg2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>> Arg2_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0_Element.Data.ToResoniteReference(context));
members.Add("Arg1", Arg1_Element.Data.ToResoniteReference(context));
members.Add("Arg2", Arg2_Element.Data.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
