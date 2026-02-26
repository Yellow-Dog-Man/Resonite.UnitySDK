
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatString
// Generated on: čtvrtek 26. února 2026 10:04:30
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatString")]
public partial class FormatString : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Format_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Object>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Object>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Object>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.Object>>> Parameters = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider> FormatProvider { get => FormatProvider_Element.Data; set => FormatProvider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>> FormatProvider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format_Element.Data.ToResoniteReference(context));
members.Add("Parameters", new ResoniteLink.SyncList()
{
    Elements = Parameters.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("FormatProvider", FormatProvider_Element.Data.ToResoniteReference(context));
}

}
}
