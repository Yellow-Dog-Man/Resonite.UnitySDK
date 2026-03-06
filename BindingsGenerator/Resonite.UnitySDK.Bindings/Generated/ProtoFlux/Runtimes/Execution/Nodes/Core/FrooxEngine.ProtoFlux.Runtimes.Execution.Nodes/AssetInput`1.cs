
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AssetInput<>
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AssetInput<>")]
public partial class AssetInput<A> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalObjectInputWithFilter<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.IAssetProvider<A>>, global::FrooxEngine.ProtoFlux.IInput<global::FrooxEngine.IAssetProvider<A>>, global::FrooxEngine.ProtoFlux.IInput
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.IAssetProvider<A> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
