
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatAssetMetadata
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatAssetMetadata")]
public partial class GaussianSplatAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat> Splat { get => Splat_Element.Data; set => Splat_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.GaussianSplat>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat>> Splat_Element = new();
public global::System.Int32 SplatCount { get => SplatCount_Element.Data; set => SplatCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> SplatCount_Element = new();
public global::System.Int64 MemoryBytes { get => MemoryBytes_Element.Data; set => MemoryBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> MemoryBytes_Element = new();
public global::System.String FormattedMemoryBytes { get => FormattedMemoryBytes_Element.Data; set => FormattedMemoryBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> FormattedMemoryBytes_Element = new();
public global::System.String ActualLoadedVariant { get => ActualLoadedVariant_Element.Data; set => ActualLoadedVariant_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> ActualLoadedVariant_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Splat", Splat_Element.ToLinkReference(context));
members.Add("SplatCount", SplatCount_Element.ToLinkField(context));
members.Add("MemoryBytes", MemoryBytes_Element.ToLinkField(context));
members.Add("FormattedMemoryBytes", FormattedMemoryBytes_Element.ToLinkField(context));
members.Add("ActualLoadedVariant", ActualLoadedVariant_Element.ToLinkField(context));
}

}
}
