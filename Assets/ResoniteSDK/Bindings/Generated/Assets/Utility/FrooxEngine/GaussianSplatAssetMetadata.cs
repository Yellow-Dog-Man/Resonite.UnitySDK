
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatAssetMetadata
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatAssetMetadata")]
public partial class GaussianSplatAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat> Splat;
public global::System.Int32 SplatCount;
public global::System.Int64 MemoryBytes;
public global::System.String FormattedMemoryBytes;
public global::System.String ActualLoadedVariant;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Splat", new ResoniteLink.Reference() { });
members.Add("SplatCount", SplatCount.ToResoniteLinkField());
members.Add("MemoryBytes", MemoryBytes.ToResoniteLinkField());
members.Add("FormattedMemoryBytes", FormattedMemoryBytes.ToResoniteLinkField());
members.Add("ActualLoadedVariant", ActualLoadedVariant.ToResoniteLinkField());
}

}
}
