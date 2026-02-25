
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatRenderer
// Generated on: středa 25. února 2026 16:14:16
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.GaussianSplat> GaussianSplat;
public global::System.Single SizeScale;
public global::System.Single OpacityScale;
public global::System.Nullable<global::System.Int32> MaxSHOrder;
public global::System.Boolean SphericalHarmonicsOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GaussianSplat", GaussianSplat.ToResoniteReference(context));
members.Add("SizeScale", SizeScale.ToResoniteLinkField());
members.Add("OpacityScale", OpacityScale.ToResoniteLinkField());
members.Add("MaxSHOrder", MaxSHOrder.ToResoniteLinkField());
members.Add("SphericalHarmonicsOnly", SphericalHarmonicsOnly.ToResoniteLinkField());
}

}
}
