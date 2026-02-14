
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugMaterial
// Generated on: sobota 14. února 2026 8:56:57
// Resonite version: 2026.2.14.493
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
