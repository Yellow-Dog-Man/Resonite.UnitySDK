
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AssetLoadProgress<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AssetLoadProgress<>")]
public partial class AssetLoadProgress<A> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UsersAssetLoadProgress<A>> Tracker;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.Nullable<global::System.Single>> DownloadProgress;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.AssetLoadState> LoadState;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tracker", Tracker.ToResoniteReference(context));
members.Add("User", User.ToResoniteReference(context));
members.Add("DownloadProgress", new ResoniteLink.EmptyElement());
members.Add("LoadState", new ResoniteLink.EmptyElement());
}

}
}
