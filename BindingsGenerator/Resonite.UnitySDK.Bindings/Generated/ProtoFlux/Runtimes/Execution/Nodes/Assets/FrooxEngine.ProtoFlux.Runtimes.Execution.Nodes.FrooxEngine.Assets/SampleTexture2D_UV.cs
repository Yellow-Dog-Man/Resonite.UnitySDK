
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleTexture2D_UV
// Generated on: čtvrtek 26. února 2026 12:27:25
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.SampleTexture2D_UV")]
public partial class SampleTexture2D_UV : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,UnityEngine.ColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D>> Texture_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> UV { get => UV_Element.Data; set => UV_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> UV_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Assets.WrapMode> WrapMode { get => WrapMode_Element.Data; set => WrapMode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Assets.WrapMode>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Elements.Assets.WrapMode>> WrapMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("UV", UV_Element.ToLinkReference(context));
members.Add("WrapMode", WrapMode_Element.ToLinkReference(context));
}

}
}
