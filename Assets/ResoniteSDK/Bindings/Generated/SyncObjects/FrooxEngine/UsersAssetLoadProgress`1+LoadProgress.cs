
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>+LoadProgress
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
    public partial class UsersAssetLoadProgress<A>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>+LoadProgress")]
public partial class LoadProgress : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.UserRef User;
public global::System.Nullable<global::System.Single> DownloadProgress;
public global::FrooxEngine.AssetLoadState LoadState;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers() });
members.Add("DownloadProgress", DownloadProgress.ToResoniteLinkField());
members.Add("LoadState", LoadState.ToResoniteLinkField());
}

}
            }
}
