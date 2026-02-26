
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ComposeBits_sbyte
// Generated on: čtvrtek 26. února 2026 12:27:59
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ComposeBits_sbyte")]
public partial class ComposeBits_sbyte : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.SByte>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit0 { get => Bit0_Element.Data; set => Bit0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit1 { get => Bit1_Element.Data; set => Bit1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit2 { get => Bit2_Element.Data; set => Bit2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit3 { get => Bit3_Element.Data; set => Bit3_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit3_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit4 { get => Bit4_Element.Data; set => Bit4_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit4_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit5 { get => Bit5_Element.Data; set => Bit5_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit5_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit6 { get => Bit6_Element.Data; set => Bit6_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit6_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit7 { get => Bit7_Element.Data; set => Bit7_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Bit7_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bit0", Bit0_Element.ToLinkReference(context));
members.Add("Bit1", Bit1_Element.ToLinkReference(context));
members.Add("Bit2", Bit2_Element.ToLinkReference(context));
members.Add("Bit3", Bit3_Element.ToLinkReference(context));
members.Add("Bit4", Bit4_Element.ToLinkReference(context));
members.Add("Bit5", Bit5_Element.ToLinkReference(context));
members.Add("Bit6", Bit6_Element.ToLinkReference(context));
members.Add("Bit7", Bit7_Element.ToLinkReference(context));
}

}
}
