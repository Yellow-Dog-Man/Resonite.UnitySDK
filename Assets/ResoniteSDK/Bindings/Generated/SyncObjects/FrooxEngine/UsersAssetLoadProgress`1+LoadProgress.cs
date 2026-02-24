
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>+LoadProgress
// Generated on: úterý 24. února 2026 18:17:34
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
