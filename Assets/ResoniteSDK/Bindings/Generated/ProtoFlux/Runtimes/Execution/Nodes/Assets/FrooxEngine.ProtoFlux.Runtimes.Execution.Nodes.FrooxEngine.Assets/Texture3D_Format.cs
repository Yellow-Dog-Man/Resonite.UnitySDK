
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.Texture3D_Format
// Generated on: čtvrtek 19. února 2026 7:59:42
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.Texture3D_Format")]
public partial class Texture3D_Format : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Texture3D> Texture;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3Int> Size;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.TextureFormat> Format;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> MipMapCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Size", new ResoniteLink.EmptyElement());
members.Add("Format", new ResoniteLink.EmptyElement());
members.Add("MipMapCount", new ResoniteLink.EmptyElement());
}

}
}
