
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticAssetProvider<,,>
// Generated on: pátek 13. února 2026 23:21:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticAssetProvider<,,>")]
public abstract partial class StaticAssetProvider<A,M,D> : global::FrooxEngine.AssetProvider<A>, global::FrooxEngine.IStaticAssetProvider
	where D : class, global::FrooxEngine.IEngineAssetVariantDescriptor
	where M : class, global::Elements.Assets.IAssetMetadata
	where A : global::FrooxEngine.Asset

{
    public System.Uri URL;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", URL.ToResoniteLinkField());
}

}
}
