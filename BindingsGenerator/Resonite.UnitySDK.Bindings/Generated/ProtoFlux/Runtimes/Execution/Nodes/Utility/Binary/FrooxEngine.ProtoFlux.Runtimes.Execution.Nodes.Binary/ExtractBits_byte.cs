
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_byte
// Generated on: čtvrtek 26. února 2026 15:09:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Byte>> Integer_Element = new();
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
members.Add("Integer", Integer_Element.ToLinkReference(context));
members.Add("Bit0", Bit0.ToLinkEmpty(context));
members.Add("Bit1", Bit1.ToLinkEmpty(context));
members.Add("Bit2", Bit2.ToLinkEmpty(context));
members.Add("Bit3", Bit3.ToLinkEmpty(context));
members.Add("Bit4", Bit4.ToLinkEmpty(context));
members.Add("Bit5", Bit5.ToLinkEmpty(context));
members.Add("Bit6", Bit6.ToLinkEmpty(context));
members.Add("Bit7", Bit7.ToLinkEmpty(context));
}

}
}
