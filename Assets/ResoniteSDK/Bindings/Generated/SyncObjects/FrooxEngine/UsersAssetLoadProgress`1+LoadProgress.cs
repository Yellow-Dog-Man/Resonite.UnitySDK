
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>+LoadProgress
// Generated on: sobota 14. února 2026 8:56:55
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("DownloadProgress", DownloadProgress.ToResoniteLinkField());
members.Add("LoadState", LoadState.ToResoniteLinkField());
}

}
            }
}
