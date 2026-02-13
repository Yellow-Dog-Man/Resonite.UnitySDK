
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMultiplexer<>
// Generated on: pátek 13. února 2026 5:51:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetMultiplexer<>")]
public partial class AssetMultiplexer<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Target;
public global::System.Int32 Index;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<A>> Assets;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Assets", new ResoniteLink.SyncList()
{
    Elements = Assets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
