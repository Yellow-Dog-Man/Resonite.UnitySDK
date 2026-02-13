
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>
// Generated on: pátek 13. února 2026 5:51:05
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Asset", new ResoniteLink.Reference() { });
members.Add("ProgressInfo", new ResoniteLink.SyncList()
{
    Elements = ProgressInfo.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
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
