
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_int
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_int")]
public partial class ExtractBits_int : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Integer { get => Integer_Element.Data; set => Integer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Integer_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit0 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit1 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit2 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit3 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit4 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit5 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit6 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit7 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit8 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit9 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit10 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit11 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit12 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit13 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit14 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit15 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit16 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit17 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit18 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit19 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit20 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit21 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit22 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit23 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit24 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit25 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit26 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit27 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit28 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit29 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit30 = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bit31 = new();

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
members.Add("Bit8", new ResoniteLink.EmptyElement());
members.Add("Bit9", new ResoniteLink.EmptyElement());
members.Add("Bit10", new ResoniteLink.EmptyElement());
members.Add("Bit11", new ResoniteLink.EmptyElement());
members.Add("Bit12", new ResoniteLink.EmptyElement());
members.Add("Bit13", new ResoniteLink.EmptyElement());
members.Add("Bit14", new ResoniteLink.EmptyElement());
members.Add("Bit15", new ResoniteLink.EmptyElement());
members.Add("Bit16", new ResoniteLink.EmptyElement());
members.Add("Bit17", new ResoniteLink.EmptyElement());
members.Add("Bit18", new ResoniteLink.EmptyElement());
members.Add("Bit19", new ResoniteLink.EmptyElement());
members.Add("Bit20", new ResoniteLink.EmptyElement());
members.Add("Bit21", new ResoniteLink.EmptyElement());
members.Add("Bit22", new ResoniteLink.EmptyElement());
members.Add("Bit23", new ResoniteLink.EmptyElement());
members.Add("Bit24", new ResoniteLink.EmptyElement());
members.Add("Bit25", new ResoniteLink.EmptyElement());
members.Add("Bit26", new ResoniteLink.EmptyElement());
members.Add("Bit27", new ResoniteLink.EmptyElement());
members.Add("Bit28", new ResoniteLink.EmptyElement());
members.Add("Bit29", new ResoniteLink.EmptyElement());
members.Add("Bit30", new ResoniteLink.EmptyElement());
members.Add("Bit31", new ResoniteLink.EmptyElement());
}

}
}
