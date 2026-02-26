
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueWriteLatch<,>
// Generated on: čtvrtek 26. února 2026 15:08:29
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueWriteLatch<,>")]
public partial class ValueWriteLatch<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteLatchBase<C,T>
	where T : struct
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T> Variable { get => Variable_Element.Data; set => Variable_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T>>, global::FrooxEngine.ProtoFlux.Runtimes.Execution.IVariable<C,T>> Variable_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> SetValue { get => SetValue_Element.Data; set => SetValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> SetValue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> ResetValue { get => ResetValue_Element.Data; set => ResetValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> ResetValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Variable", Variable_Element.ToLinkReference(context));
members.Add("SetValue", SetValue_Element.ToLinkReference(context));
members.Add("ResetValue", ResetValue_Element.ToLinkReference(context));
}

}
}
