
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AssetLoadProgress<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.AssetLoadProgress<>")]
public partial class AssetLoadProgress<A> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UsersAssetLoadProgress<A>> Tracker { get => Tracker_Element.Data; set => Tracker_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UsersAssetLoadProgress<A>>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.UsersAssetLoadProgress<A>>> Tracker_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> User_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::System.Nullable<global::System.Single>> DownloadProgress = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::FrooxEngine.AssetLoadState> LoadState = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tracker", Tracker_Element.ToLinkReference(context));
members.Add("User", User_Element.ToLinkReference(context));
members.Add("DownloadProgress", DownloadProgress.ToLinkEmpty(context));
members.Add("LoadState", LoadState.ToLinkEmpty(context));
}

}
}
