
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.RenderToTextureAsset
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.RenderToTextureAsset")]
public partial class RenderToTextureAsset : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Camera> Camera;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Int> Resolution;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Format;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Quality;
public global::FrooxEngine.ProtoFlux.INodeOperation OnRenderStarted;
public global::FrooxEngine.ProtoFlux.INodeOperation OnRendered;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFailed;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> RenderedAssetURL;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Camera", new ResoniteLink.Reference() { });
members.Add("Resolution", new ResoniteLink.Reference() { });
members.Add("Format", new ResoniteLink.Reference() { });
members.Add("Quality", new ResoniteLink.Reference() { });
members.Add("OnRenderStarted", new ResoniteLink.Reference() { });
members.Add("OnRendered", new ResoniteLink.Reference() { });
members.Add("OnFailed", new ResoniteLink.Reference() { });
members.Add("RenderedAssetURL", new ResoniteLink.EmptyElement());
}

}
}
