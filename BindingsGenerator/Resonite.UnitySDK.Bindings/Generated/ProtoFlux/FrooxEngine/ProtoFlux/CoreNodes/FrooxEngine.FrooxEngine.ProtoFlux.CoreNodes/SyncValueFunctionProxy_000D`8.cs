
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_000D<,,,,,,,>
// Generated on: čtvrtek 26. února 2026 10:04:02
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.SyncValueFunctionProxy_000D<,,,,,,,>")]
public partial class SyncValueFunctionProxy_000D<T0,T1,T2,T3,T4,T5,T6,TResult> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.DataModelMethodProxy<global::System.Func<T0,T1,T2,T3,T4,T5,T6,TResult>>
	where TResult : struct
	where T6 : struct
	where T5 : struct
	where T4 : struct
	
	
	where T1 : struct
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0> Arg0 { get => Arg0_Element.Data; set => Arg0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T0>> Arg0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T1> Arg1 { get => Arg1_Element.Data; set => Arg1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>> Arg1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2> Arg2 { get => Arg2_Element.Data; set => Arg2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T2>> Arg2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3> Arg3 { get => Arg3_Element.Data; set => Arg3_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T3>> Arg3_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T4> Arg4 { get => Arg4_Element.Data; set => Arg4_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T4>> Arg4_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T5> Arg5 { get => Arg5_Element.Data; set => Arg5_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T5>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T5>> Arg5_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T6> Arg6 { get => Arg6_Element.Data; set => Arg6_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T6>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T6>> Arg6_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<TResult> Result = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arg0", Arg0_Element.Data.ToResoniteReference(context));
members.Add("Arg1", Arg1_Element.Data.ToResoniteReference(context));
members.Add("Arg2", Arg2_Element.Data.ToResoniteReference(context));
members.Add("Arg3", Arg3_Element.Data.ToResoniteReference(context));
members.Add("Arg4", Arg4_Element.Data.ToResoniteReference(context));
members.Add("Arg5", Arg5_Element.Data.ToResoniteReference(context));
members.Add("Arg6", Arg6_Element.Data.ToResoniteReference(context));
members.Add("Result", new ResoniteLink.EmptyElement());
}

}
}
