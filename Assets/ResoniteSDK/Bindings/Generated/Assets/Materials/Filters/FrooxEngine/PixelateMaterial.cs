
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PixelateMaterial
// Generated on: pátek 13. února 2026 23:21:32
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PixelateMaterial")]
public partial class PixelateMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::System.Boolean PerObject;
public UnityEngine.Vector2 Resolution;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ResolutionMagnitudeTexture;
public UnityEngine.Vector2 ResolutionTextureScale;
public UnityEngine.Vector2 ResolutionTextureOffset;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _global;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _perObject;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PerObject", PerObject.ToResoniteLinkField());
members.Add("Resolution", Resolution.ToResoniteLinkField());
members.Add("ResolutionMagnitudeTexture", new ResoniteLink.Reference() { });
members.Add("ResolutionTextureScale", ResolutionTextureScale.ToResoniteLinkField());
members.Add("ResolutionTextureOffset", ResolutionTextureOffset.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("_global", new ResoniteLink.Reference() { });
members.Add("_perObject", new ResoniteLink.Reference() { });
}

}
}
