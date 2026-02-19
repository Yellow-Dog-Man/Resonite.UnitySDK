
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>
// Generated on: čtvrtek 19. února 2026 7:58:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>")]
public partial class UsersAssetLoadProgress<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.IAssetProvider<A> Asset;
public System.Collections.Generic.List<global::FrooxEngine.UsersAssetLoadProgress<A>.LoadProgress> ProgressInfo;
public global::System.Int32 TotalUsers;
public global::System.Int32 UsersNotLoaded;
public global::System.Int32 UsersLoading;
public global::System.Int32 UsersPartiallyLoaded;
public global::System.Int32 UsersFullyLoaded;
public global::System.Int32 UsersFailedToLoad;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset.ToResoniteReference(context));
members.Add("ProgressInfo", new ResoniteLink.SyncList()
{
    Elements = ProgressInfo.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("TotalUsers", TotalUsers.ToResoniteLinkField());
members.Add("UsersNotLoaded", UsersNotLoaded.ToResoniteLinkField());
members.Add("UsersLoading", UsersLoading.ToResoniteLinkField());
members.Add("UsersPartiallyLoaded", UsersPartiallyLoaded.ToResoniteLinkField());
members.Add("UsersFullyLoaded", UsersFullyLoaded.ToResoniteLinkField());
members.Add("UsersFailedToLoad", UsersFailedToLoad.ToResoniteLinkField());
}

}
}
