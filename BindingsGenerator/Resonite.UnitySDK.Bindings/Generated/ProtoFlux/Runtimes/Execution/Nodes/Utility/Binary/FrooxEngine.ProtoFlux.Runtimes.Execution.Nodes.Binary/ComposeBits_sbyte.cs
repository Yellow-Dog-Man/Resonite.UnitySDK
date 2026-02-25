
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ComposeBits_sbyte
// Generated on: středa 25. února 2026 16:14:12
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Bit0", Bit0.ToResoniteReference(context));
members.Add("Bit1", Bit1.ToResoniteReference(context));
members.Add("Bit2", Bit2.ToResoniteReference(context));
members.Add("Bit3", Bit3.ToResoniteReference(context));
members.Add("Bit4", Bit4.ToResoniteReference(context));
members.Add("Bit5", Bit5.ToResoniteReference(context));
members.Add("Bit6", Bit6.ToResoniteReference(context));
members.Add("Bit7", Bit7.ToResoniteReference(context));
}

}
}
