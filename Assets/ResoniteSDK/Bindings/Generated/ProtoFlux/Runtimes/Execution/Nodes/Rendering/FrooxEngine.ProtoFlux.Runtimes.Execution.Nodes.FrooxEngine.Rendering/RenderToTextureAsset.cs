
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.RenderToTextureAsset
// Generated on: úterý 24. února 2026 18:19:49
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Camera", Camera.ToResoniteReference(context));
members.Add("Resolution", Resolution.ToResoniteReference(context));
members.Add("Format", Format.ToResoniteReference(context));
members.Add("Quality", Quality.ToResoniteReference(context));
members.Add("OnRenderStarted", OnRenderStarted.ToResoniteReference(context));
members.Add("OnRendered", OnRendered.ToResoniteReference(context));
members.Add("OnFailed", OnFailed.ToResoniteReference(context));
members.Add("RenderedAssetURL", new ResoniteLink.EmptyElement());
}

}
}
