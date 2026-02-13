
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RefractMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RefractMaterial")]
public partial class RefractMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::System.Single RefractionStrength;
public global::System.Single DepthBias;
public global::System.Single DepthFadeDivisor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public UnityEngine.Vector2 NormalTextureScale;
public UnityEngine.Vector2 NormalTextureOffset;
public global::System.Boolean PerObject;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _global;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _perObject;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RefractionStrength", RefractionStrength.ToResoniteLinkField());
members.Add("DepthBias", DepthBias.ToResoniteLinkField());
members.Add("DepthFadeDivisor", DepthFadeDivisor.ToResoniteLinkField());
members.Add("NormalMap", new ResoniteLink.Reference() { });
members.Add("NormalTextureScale", NormalTextureScale.ToResoniteLinkField());
members.Add("NormalTextureOffset", NormalTextureOffset.ToResoniteLinkField());
members.Add("PerObject", PerObject.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("_global", new ResoniteLink.Reference() { });
members.Add("_perObject", new ResoniteLink.Reference() { });
}

}
}
