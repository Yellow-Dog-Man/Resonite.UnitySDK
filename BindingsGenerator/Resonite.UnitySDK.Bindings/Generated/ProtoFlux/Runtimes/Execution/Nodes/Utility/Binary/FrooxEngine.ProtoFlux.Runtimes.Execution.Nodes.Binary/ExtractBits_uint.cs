
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_uint
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Binary.ExtractBits_uint")]
public partial class ExtractBits_uint : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32> Integer { get => Integer_Element.Data; set => Integer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>> Integer_Element = new();
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
members.Add("Integer", Integer_Element.ToLinkReference(context));
members.Add("Bit0", Bit0.ToLinkEmpty(context));
members.Add("Bit1", Bit1.ToLinkEmpty(context));
members.Add("Bit2", Bit2.ToLinkEmpty(context));
members.Add("Bit3", Bit3.ToLinkEmpty(context));
members.Add("Bit4", Bit4.ToLinkEmpty(context));
members.Add("Bit5", Bit5.ToLinkEmpty(context));
members.Add("Bit6", Bit6.ToLinkEmpty(context));
members.Add("Bit7", Bit7.ToLinkEmpty(context));
members.Add("Bit8", Bit8.ToLinkEmpty(context));
members.Add("Bit9", Bit9.ToLinkEmpty(context));
members.Add("Bit10", Bit10.ToLinkEmpty(context));
members.Add("Bit11", Bit11.ToLinkEmpty(context));
members.Add("Bit12", Bit12.ToLinkEmpty(context));
members.Add("Bit13", Bit13.ToLinkEmpty(context));
members.Add("Bit14", Bit14.ToLinkEmpty(context));
members.Add("Bit15", Bit15.ToLinkEmpty(context));
members.Add("Bit16", Bit16.ToLinkEmpty(context));
members.Add("Bit17", Bit17.ToLinkEmpty(context));
members.Add("Bit18", Bit18.ToLinkEmpty(context));
members.Add("Bit19", Bit19.ToLinkEmpty(context));
members.Add("Bit20", Bit20.ToLinkEmpty(context));
members.Add("Bit21", Bit21.ToLinkEmpty(context));
members.Add("Bit22", Bit22.ToLinkEmpty(context));
members.Add("Bit23", Bit23.ToLinkEmpty(context));
members.Add("Bit24", Bit24.ToLinkEmpty(context));
members.Add("Bit25", Bit25.ToLinkEmpty(context));
members.Add("Bit26", Bit26.ToLinkEmpty(context));
members.Add("Bit27", Bit27.ToLinkEmpty(context));
members.Add("Bit28", Bit28.ToLinkEmpty(context));
members.Add("Bit29", Bit29.ToLinkEmpty(context));
members.Add("Bit30", Bit30.ToLinkEmpty(context));
members.Add("Bit31", Bit31.ToLinkEmpty(context));
}

}
}
