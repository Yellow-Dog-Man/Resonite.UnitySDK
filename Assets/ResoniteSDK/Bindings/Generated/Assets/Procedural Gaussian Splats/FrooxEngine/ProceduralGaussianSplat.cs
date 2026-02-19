
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralGaussianSplat
// Generated on: čtvrtek 19. února 2026 7:58:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralGaussianSplat")]
public abstract partial class ProceduralGaussianSplat : global::FrooxEngine.ProceduralAssetProvider<global::FrooxEngine.GaussianSplat>

{
    public global::System.Boolean OverrideBoundingBox;
public UnityEngine.Bounds OverridenBoundingBox;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideBoundingBox", OverrideBoundingBox.ToResoniteLinkField());
members.Add("OverridenBoundingBox", OverridenBoundingBox.ToResoniteLinkField());
}

}
}
