
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticAssetProvider<,,>
// Generated on: čtvrtek 19. února 2026 7:58:49
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
}

}
}
