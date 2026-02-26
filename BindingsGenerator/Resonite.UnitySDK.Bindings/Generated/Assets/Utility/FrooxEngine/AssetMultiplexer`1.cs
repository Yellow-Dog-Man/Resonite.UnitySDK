
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMultiplexer<>
// Generated on: čtvrtek 26. února 2026 15:07:56
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetMultiplexer<>")]
public partial class AssetMultiplexer<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<A>>, global::FrooxEngine.AssetRef<A>> Target_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<A>, global::FrooxEngine.IAssetProvider<A>, Reference<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>>> Assets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Index", Index_Element.ToLinkField(context));
members.Add("Assets", Assets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
