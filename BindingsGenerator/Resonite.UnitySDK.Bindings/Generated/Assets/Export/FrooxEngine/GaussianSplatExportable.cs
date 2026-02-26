
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatExportable
// Generated on: čtvrtek 26. února 2026 15:07:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatExportable")]
public partial class GaussianSplatExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat> Splat { get => Splat_Element.Data; set => Splat_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.GaussianSplat>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat>> Splat_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Splat", Splat_Element.ToLinkReference(context));
}

}
}
