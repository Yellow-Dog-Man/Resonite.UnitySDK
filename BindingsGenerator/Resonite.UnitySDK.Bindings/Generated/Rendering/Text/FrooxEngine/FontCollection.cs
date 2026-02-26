
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontCollection
// Generated on: čtvrtek 26. února 2026 15:09:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontCollection")]
public partial class FontCollection : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.FontSet>

{
    public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.FontSet>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>, Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.FontSet>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>>> FontSets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FontSets", FontSets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
