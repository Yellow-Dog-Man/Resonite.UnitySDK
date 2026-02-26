
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHSV
// Generated on: čtvrtek 26. února 2026 15:08:30
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHSV")]
public partial class ColorXToHSV : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> C { get => C_Element.Data; set => C_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>> C_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> H = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> S = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> V = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("C", C_Element.ToLinkReference(context));
members.Add("H", H.ToLinkEmpty(context));
members.Add("S", S.ToLinkEmpty(context));
members.Add("V", V.ToLinkEmpty(context));
}

}
}
