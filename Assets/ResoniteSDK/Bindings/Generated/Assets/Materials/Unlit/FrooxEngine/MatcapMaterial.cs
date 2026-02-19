
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MatcapMaterial
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
