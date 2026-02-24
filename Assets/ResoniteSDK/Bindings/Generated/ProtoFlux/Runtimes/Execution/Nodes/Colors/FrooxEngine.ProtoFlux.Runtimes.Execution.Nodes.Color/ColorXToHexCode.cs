
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHexCode
// Generated on: úterý 24. února 2026 18:18:58
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHexCode")]
public partial class ColorXToHexCode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Color;
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
