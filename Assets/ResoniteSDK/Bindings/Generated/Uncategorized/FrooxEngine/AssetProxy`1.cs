
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetProxy<>
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetProxy<>")]
public partial class AssetProxy<A> : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<global::FrooxEngine.IAssetProvider<A>>, global::FrooxEngine.IReferenceSource
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.IAssetProvider<A> AssetReference;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AssetReference", new ResoniteLink.Reference() { });
}

}
}
