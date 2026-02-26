
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy_001F<,,,,,,,,>
// Generated on: čtvrtek 26. února 2026 15:08:08
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.AsyncObjectFunctionProxy_001F<,,,,,,,,>")]
public partial class AsyncObjectFunctionProxy_001F<T0,T1,T2,T3,T4,T5,T6,T7,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelAsyncMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,T6,T7,global::System.Threading.Tasks.Task<TResult>>>
	
	where T7 : struct
	where T6 : struct
	where T5 : struct
	
	
	
	
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0 { get => Arg0_Element.Data; set => Arg0_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>> Arg0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1> Arg1 { get => Arg1_Element.Data; set => Arg1_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T1>> Arg1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2 { get => Arg2_Element.Data; set => Arg2_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>> Arg2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3 { get => Arg3_Element.Data; set => Arg3_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>> Arg3_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4> Arg4 { get => Arg4_Element.Data; set => Arg4_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T4>> Arg4_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T5> Arg5 { get => Arg5_Element.Data; set => Arg5_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T5>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T5>> Arg5_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T6> Arg6 { get => Arg6_Element.Data; set => Arg6_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T6>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T6>> Arg6_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T7> Arg7 { get => Arg7_Element.Data; set => Arg7_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T7>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T7>> Arg7_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0_Element.ToLinkReference(context));
members.Add("Arg1", Arg1_Element.ToLinkReference(context));
members.Add("Arg2", Arg2_Element.ToLinkReference(context));
members.Add("Arg3", Arg3_Element.ToLinkReference(context));
members.Add("Arg4", Arg4_Element.ToLinkReference(context));
members.Add("Arg5", Arg5_Element.ToLinkReference(context));
members.Add("Arg6", Arg6_Element.ToLinkReference(context));
members.Add("Arg7", Arg7_Element.ToLinkReference(context));
members.Add("Result", Result.ToLinkEmpty(context));
}

}
}
