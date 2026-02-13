
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ComposeBits_sbyte
// Generated on: pátek 13. února 2026 23:22:59
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit3;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit4;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit5;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit6;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Bit7;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Bit0", new ResoniteLink.Reference() { });
members.Add("Bit1", new ResoniteLink.Reference() { });
members.Add("Bit2", new ResoniteLink.Reference() { });
members.Add("Bit3", new ResoniteLink.Reference() { });
members.Add("Bit4", new ResoniteLink.Reference() { });
members.Add("Bit5", new ResoniteLink.Reference() { });
members.Add("Bit6", new ResoniteLink.Reference() { });
members.Add("Bit7", new ResoniteLink.Reference() { });
}

}
}
