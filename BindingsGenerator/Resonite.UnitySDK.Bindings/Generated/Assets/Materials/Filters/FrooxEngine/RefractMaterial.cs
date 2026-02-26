
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RefractMaterial
// Generated on: čtvrtek 26. února 2026 12:26:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RefractMaterial")]
public partial class RefractMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::System.Single RefractionStrength { get => RefractionStrength_Element.Data; set => RefractionStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RefractionStrength_Element = new();
public global::System.Single DepthBias { get => DepthBias_Element.Data; set => DepthBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthBias_Element = new();
public global::System.Single DepthFadeDivisor { get => DepthFadeDivisor_Element.Data; set => DepthFadeDivisor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthFadeDivisor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public UnityEngine.Vector2 NormalTextureScale { get => NormalTextureScale_Element.Data; set => NormalTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalTextureScale_Element = new();
public UnityEngine.Vector2 NormalTextureOffset { get => NormalTextureOffset_Element.Data; set => NormalTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalTextureOffset_Element = new();
public global::System.Boolean PerObject { get => PerObject_Element.Data; set => PerObject_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PerObject_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _global { get => _global_Element.Data; set => _global_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _global_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _perObject { get => _perObject_Element.Data; set => _perObject_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _perObject_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RefractionStrength", RefractionStrength_Element.ToLinkField(context));
members.Add("DepthBias", DepthBias_Element.ToLinkField(context));
members.Add("DepthFadeDivisor", DepthFadeDivisor_Element.ToLinkField(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalTextureScale", NormalTextureScale_Element.ToLinkField(context));
members.Add("NormalTextureOffset", NormalTextureOffset_Element.ToLinkField(context));
members.Add("PerObject", PerObject_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
members.Add("_global", _global_Element.ToLinkReference(context));
members.Add("_perObject", _perObject_Element.ToLinkReference(context));
}

}
}
