
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralGaussianSplat
// Generated on: čtvrtek 26. února 2026 12:26:50
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralGaussianSplat")]
public abstract partial class ProceduralGaussianSplat : global::FrooxEngine.ProceduralAssetProvider<global::FrooxEngine.GaussianSplat>

{
    public global::System.Boolean OverrideBoundingBox { get => OverrideBoundingBox_Element.Data; set => OverrideBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OverrideBoundingBox_Element = new();
public UnityEngine.Bounds OverridenBoundingBox { get => OverridenBoundingBox_Element.Data; set => OverridenBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> OverridenBoundingBox_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideBoundingBox", OverrideBoundingBox_Element.ToLinkField(context));
members.Add("OverridenBoundingBox", OverridenBoundingBox_Element.ToLinkField(context));
}

}
}
