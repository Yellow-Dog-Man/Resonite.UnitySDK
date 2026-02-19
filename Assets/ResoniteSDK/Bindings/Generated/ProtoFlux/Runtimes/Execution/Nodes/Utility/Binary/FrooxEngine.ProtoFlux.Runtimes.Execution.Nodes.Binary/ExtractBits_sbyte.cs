
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_sbyte
// Generated on: čtvrtek 19. února 2026 8:00:15
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_sbyte")]
public partial class ExtractBits_sbyte : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> Integer;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit0;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit1;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit2;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit3;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit4;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit5;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit6;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit7;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Integer", Integer.ToResoniteReference(context));
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
