
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMultiplexer<>
// Generated on: úterý 24. února 2026 18:17:42
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetMultiplexer<>")]
public partial class AssetMultiplexer<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Target;
public global::System.Int32 Index;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<A>> Assets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Assets", new ResoniteLink.SyncList()
{
    Elements = Assets.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
