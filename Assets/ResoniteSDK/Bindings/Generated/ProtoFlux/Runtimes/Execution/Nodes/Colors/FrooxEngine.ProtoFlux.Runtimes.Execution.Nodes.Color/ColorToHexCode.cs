
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode
// Generated on: čtvrtek 19. února 2026 7:59:43
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode")]
public partial class ColorToHexCode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> Color;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShortForm;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeAlpha;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Prefix;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteReference(context));
members.Add("ShortForm", ShortForm.ToResoniteReference(context));
members.Add("IncludeAlpha", IncludeAlpha.ToResoniteReference(context));
members.Add("Prefix", Prefix.ToResoniteReference(context));
}

}
}
