
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetProxy<>
// Generated on: čtvrtek 26. února 2026 10:04:43
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.IAssetProvider<A> AssetReference { get => AssetReference_Element.Data; set => AssetReference_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> AssetReference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AssetReference", AssetReference_Element.Data.ToResoniteReference(context));
}

}
}
