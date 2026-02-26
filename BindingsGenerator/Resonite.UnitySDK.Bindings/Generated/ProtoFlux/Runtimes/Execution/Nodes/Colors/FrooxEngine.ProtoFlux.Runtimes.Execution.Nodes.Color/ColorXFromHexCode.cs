
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXFromHexCode
// Generated on: čtvrtek 26. února 2026 12:27:27
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXFromHexCode")]
public partial class ColorXFromHexCode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> HexCode { get => HexCode_Element.Data; set => HexCode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> HexCode_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.ColorX> Color = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Parsed = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HexCode", HexCode_Element.ToLinkReference(context));
members.Add("Color", Color.ToLinkEmpty(context));
members.Add("Parsed", Parsed.ToLinkEmpty(context));
}

}
}
