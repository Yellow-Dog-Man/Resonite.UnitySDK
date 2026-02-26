
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatRenderer
// Generated on: čtvrtek 26. února 2026 10:04:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatRenderer")]
public partial class GaussianSplatRenderer : global::FrooxEngine.ChangeHandlingRenderableComponent, global::FrooxEngine.IBounded, global::FrooxEngine.IRenderable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat> GaussianSplat { get => GaussianSplat_Element.Data; set => GaussianSplat_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.GaussianSplat>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat>> GaussianSplat_Element = new();
public global::System.Single SizeScale { get => SizeScale_Element.Data; set => SizeScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SizeScale_Element = new();
public global::System.Single OpacityScale { get => OpacityScale_Element.Data; set => OpacityScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OpacityScale_Element = new();
public global::System.Nullable<global::System.Int32> MaxSHOrder { get => MaxSHOrder_Element.Data; set => MaxSHOrder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MaxSHOrder_Element = new();
public global::System.Boolean SphericalHarmonicsOnly { get => SphericalHarmonicsOnly_Element.Data; set => SphericalHarmonicsOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SphericalHarmonicsOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GaussianSplat", GaussianSplat_Element.Data.ToResoniteReference(context));
members.Add("SizeScale", SizeScale_Element.Data.ToResoniteLinkField());
members.Add("OpacityScale", OpacityScale_Element.Data.ToResoniteLinkField());
members.Add("MaxSHOrder", MaxSHOrder_Element.Data.ToResoniteLinkField());
members.Add("SphericalHarmonicsOnly", SphericalHarmonicsOnly_Element.Data.ToResoniteLinkField());
}

}
}
