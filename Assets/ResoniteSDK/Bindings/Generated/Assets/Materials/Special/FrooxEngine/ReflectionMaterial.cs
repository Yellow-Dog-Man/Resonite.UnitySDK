
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionMaterial
// Generated on: pátek 13. února 2026 5:51:06
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionMaterial")]
public partial class ReflectionMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ReflectionTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public UnityEngine.Vector2 NormalMapScale;
public UnityEngine.Vector2 NormalMapOffset;
public global::System.Single Distort;
public UnityEngine.ColorX TintColor;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReflectionTexture", new ResoniteLink.Reference() { });
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalMapScale", NormalMapScale.ToResoniteLinkField());
members.Add("NormalMapOffset", NormalMapOffset.ToResoniteLinkField());
members.Add("Distort", Distort.ToResoniteLinkField());
members.Add("TintColor", TintColor.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
