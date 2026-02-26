
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.Texture2D_Format
// Generated on: čtvrtek 26. února 2026 15:08:29
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.Texture2D_Format")]
public partial class Texture2D_Format : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture2D>> Texture_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2Int> Size = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.TextureFormat> Format = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> MipMapCount = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Size", Size.ToLinkEmpty(context));
members.Add("Format", Format.ToLinkEmpty(context));
members.Add("MipMapCount", MipMapCount.ToLinkEmpty(context));
}

}
}
