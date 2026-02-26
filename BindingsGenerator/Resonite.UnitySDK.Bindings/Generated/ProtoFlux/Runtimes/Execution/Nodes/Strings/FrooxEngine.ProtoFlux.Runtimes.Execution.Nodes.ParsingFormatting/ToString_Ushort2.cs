
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.ToString_Ushort2
// Generated on: čtvrtek 26. února 2026 12:27:55
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.ToString_Ushort2")]
public partial class ToString_Ushort2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort> V { get => V_Element.Data; set => V_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort>> V_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Format_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider> FormatProvider { get => FormatProvider_Element.Data; set => FormatProvider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider>> FormatProvider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("Format", Format_Element.ToLinkReference(context));
members.Add("FormatProvider", FormatProvider_Element.ToLinkReference(context));
}

}
}
