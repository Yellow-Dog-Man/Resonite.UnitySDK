
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AssetInput<>
// Generated on: pátek 13. února 2026 23:22:21
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.IAssetProvider<A> Target;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
}

}
}
