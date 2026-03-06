
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.GetAsset<>
// Generated on: pátek 6. března 2026 14:18:35
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.GetAsset<>")]
public partial class GetAsset<A> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,A>
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<A>> Provider { get => Provider_Element.Data; set => Provider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<A>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAssetProvider<A>>> Provider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Provider", Provider_Element.ToLinkReference(context));
}

}
}
