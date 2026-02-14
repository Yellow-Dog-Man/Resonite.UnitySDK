
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetProxy<>
// Generated on: sobota 14. února 2026 8:58:41
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetProxy<>")]
public partial class AssetProxy<A> : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<global::FrooxEngine.IAssetProvider<A>>, global::FrooxEngine.IReferenceSource
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.IAssetProvider<A> AssetReference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AssetReference", AssetReference.ToResoniteReference(context));
}

}
}
