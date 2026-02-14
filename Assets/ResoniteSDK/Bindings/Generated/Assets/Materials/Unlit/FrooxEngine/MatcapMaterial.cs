
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MatcapMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MatcapMaterial")]
public partial class MatcapMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Matcap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matcap", Matcap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
