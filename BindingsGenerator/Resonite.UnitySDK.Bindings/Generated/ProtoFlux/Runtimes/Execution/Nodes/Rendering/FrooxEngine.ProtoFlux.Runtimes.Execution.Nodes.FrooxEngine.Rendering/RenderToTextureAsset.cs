
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Rendering.RenderToTextureAsset
// Generated on: čtvrtek 26. února 2026 15:08:55
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Camera> Camera { get => Camera_Element.Data; set => Camera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Camera>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Camera>> Camera_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Int> Resolution { get => Resolution_Element.Data; set => Resolution_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Int>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Int>> Resolution_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Format_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Quality { get => Quality_Element.Data; set => Quality_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> Quality_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnRenderStarted { get => OnRenderStarted_Element.Data; set => OnRenderStarted_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnRenderStarted_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnRendered { get => OnRendered_Element.Data; set => OnRendered_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnRendered_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFailed { get => OnFailed_Element.Data; set => OnFailed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFailed_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.Uri> RenderedAssetURL = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Camera", Camera_Element.ToLinkReference(context));
members.Add("Resolution", Resolution_Element.ToLinkReference(context));
members.Add("Format", Format_Element.ToLinkReference(context));
members.Add("Quality", Quality_Element.ToLinkReference(context));
members.Add("OnRenderStarted", OnRenderStarted_Element.ToLinkReference(context));
members.Add("OnRendered", OnRendered_Element.ToLinkReference(context));
members.Add("OnFailed", OnFailed_Element.ToLinkReference(context));
members.Add("RenderedAssetURL", RenderedAssetURL.ToLinkEmpty(context));
}

}
}
