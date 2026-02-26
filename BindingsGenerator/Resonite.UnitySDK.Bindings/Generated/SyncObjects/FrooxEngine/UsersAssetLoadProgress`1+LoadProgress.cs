
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>+LoadProgress
// Generated on: čtvrtek 26. února 2026 15:07:52
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UserRef User = new();
public global::System.Nullable<global::System.Single> DownloadProgress { get => DownloadProgress_Element.Data; set => DownloadProgress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> DownloadProgress_Element = new();
public global::FrooxEngine.AssetLoadState LoadState { get => LoadState_Element.Data; set => LoadState_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AssetLoadState>, global::FrooxEngine.AssetLoadState> LoadState_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToLinkSyncObject(context));
members.Add("DownloadProgress", DownloadProgress_Element.ToLinkField(context));
members.Add("LoadState", LoadState_Element.ToLinkField(context));
}

}
            }
}
