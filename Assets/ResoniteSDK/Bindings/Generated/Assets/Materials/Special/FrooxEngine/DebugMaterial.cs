
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugMaterial
// Generated on: čtvrtek 19. února 2026 7:58:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugMaterial")]
public partial class DebugMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Scale;
public UnityEngine.Vector3 Offset;
public global::FrooxEngine.DebugMaterial.MeshData Visualize;
public global::System.Boolean Normalize;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Visualize", Visualize.ToResoniteLinkField());
members.Add("Normalize", Normalize.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
