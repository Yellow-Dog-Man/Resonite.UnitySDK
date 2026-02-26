
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXHue
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXHue")]
public partial class ColorXHue : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.ColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Hue { get => Hue_Element.Data; set => Hue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Hue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile> TargetProfile { get => TargetProfile_Element.Data; set => TargetProfile_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile>> TargetProfile_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Hue", Hue_Element.ToLinkReference(context));
members.Add("TargetProfile", TargetProfile_Element.ToLinkReference(context));
}

}
}
