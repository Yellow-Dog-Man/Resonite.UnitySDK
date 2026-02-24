
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AttachAsset<>
// Generated on: úterý 24. února 2026 18:18:55
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AttachAsset<>")]
public abstract partial class AttachAsset<A> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where A : class, global::FrooxEngine.IAssetProvider

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<System.Uri> URL;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Target;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetExisting;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<A> AttachedProvider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("GetExisting", GetExisting.ToResoniteReference(context));
members.Add("AttachedProvider", new ResoniteLink.EmptyElement());
}

}
}
