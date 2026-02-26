
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode
// Generated on: čtvrtek 26. února 2026 10:04:07
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHexCode")]
public partial class ColorToHexCode : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>> Color_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShortForm { get => ShortForm_Element.Data; set => ShortForm_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ShortForm_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeAlpha { get => IncludeAlpha_Element.Data; set => IncludeAlpha_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> IncludeAlpha_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Prefix { get => Prefix_Element.Data; set => Prefix_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Prefix_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.Data.ToResoniteReference(context));
members.Add("ShortForm", ShortForm_Element.Data.ToResoniteReference(context));
members.Add("IncludeAlpha", IncludeAlpha_Element.Data.ToResoniteReference(context));
members.Add("Prefix", Prefix_Element.Data.ToResoniteReference(context));
}

}
}
