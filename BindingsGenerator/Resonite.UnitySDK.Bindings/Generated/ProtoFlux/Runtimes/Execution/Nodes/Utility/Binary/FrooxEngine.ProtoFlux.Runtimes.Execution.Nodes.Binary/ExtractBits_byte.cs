
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_byte
// Generated on: čtvrtek 26. února 2026 10:04:34
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_byte")]
public partial class ExtractBits_byte : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte> Integer { get => Integer_Element.Data; set => Integer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte>> Integer_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit3 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit4 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit5 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit6 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit7 = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Integer", Integer_Element.Data.ToResoniteReference(context));
members.Add("Bit0", new ResoniteLink.EmptyElement());
members.Add("Bit1", new ResoniteLink.EmptyElement());
members.Add("Bit2", new ResoniteLink.EmptyElement());
members.Add("Bit3", new ResoniteLink.EmptyElement());
members.Add("Bit4", new ResoniteLink.EmptyElement());
members.Add("Bit5", new ResoniteLink.EmptyElement());
members.Add("Bit6", new ResoniteLink.EmptyElement());
members.Add("Bit7", new ResoniteLink.EmptyElement());
}

}
}
