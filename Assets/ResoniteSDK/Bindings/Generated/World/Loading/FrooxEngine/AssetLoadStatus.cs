
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetLoadStatus
// Generated on: pátek 13. února 2026 23:23:21
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetLoadStatus")]
public partial class AssetLoadStatus : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.IAsset>> Assets;
public global::System.Boolean IsLoaded;
public global::System.Single LoadProgress;
public global::System.Single ProgressWeight;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Assets", new ResoniteLink.SyncList()
{
    Elements = Assets.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("IsLoaded", IsLoaded.ToResoniteLinkField());
members.Add("LoadProgress", LoadProgress.ToResoniteLinkField());
members.Add("ProgressWeight", ProgressWeight.ToResoniteLinkField());
}

}
}
