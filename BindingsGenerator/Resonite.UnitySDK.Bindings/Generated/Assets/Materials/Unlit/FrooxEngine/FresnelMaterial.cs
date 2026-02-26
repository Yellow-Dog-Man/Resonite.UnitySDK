
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FresnelMaterial
// Generated on: čtvrtek 26. února 2026 12:26:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FresnelMaterial")]
public partial class FresnelMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Exponent { get => Exponent_Element.Data; set => Exponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exponent_Element = new();
public global::System.Single GammaCurve { get => GammaCurve_Element.Data; set => GammaCurve_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GammaCurve_Element = new();
public UnityEngine.ColorX FarColor { get => FarColor_Element.Data; set => FarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FarColor_Element = new();
public UnityEngine.ColorX NearColor { get => NearColor_Element.Data; set => NearColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NearColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture { get => FarTexture_Element.Data; set => FarTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FarTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture { get => NearTexture_Element.Data; set => NearTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NearTexture_Element = new();
public UnityEngine.Vector2 FarTextureScale { get => FarTextureScale_Element.Data; set => FarTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FarTextureScale_Element = new();
public UnityEngine.Vector2 FarTextureOffset { get => FarTextureOffset_Element.Data; set => FarTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FarTextureOffset_Element = new();
public UnityEngine.Vector2 NearTextureScale { get => NearTextureScale_Element.Data; set => NearTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NearTextureScale_Element = new();
public UnityEngine.Vector2 NearTextureOffset { get => NearTextureOffset_Element.Data; set => NearTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NearTextureOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::System.Boolean UseVertexColors { get => UseVertexColors_Element.Data; set => UseVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVertexColors_Element = new();
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace { get => VertexColorInterpolationSpace_Element.Data; set => VertexColorInterpolationSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> VertexColorInterpolationSpace_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture { get => MaskTexture_Element.Data; set => MaskTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MaskTexture_Element = new();
public UnityEngine.Vector2 MaskScale { get => MaskScale_Element.Data; set => MaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskScale_Element = new();
public UnityEngine.Vector2 MaskOffset { get => MaskOffset_Element.Data; set => MaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskOffset_Element = new();
public global::FrooxEngine.MaskTextureMode MaskMode { get => MaskMode_Element.Data; set => MaskMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MaskTextureMode>, global::FrooxEngine.MaskTextureMode> MaskMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::System.Boolean PolarUVmapping { get => PolarUVmapping_Element.Data; set => PolarUVmapping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PolarUVmapping_Element = new();
public global::System.Single PolarPower { get => PolarPower_Element.Data; set => PolarPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PolarPower_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exponent", Exponent_Element.ToLinkField(context));
members.Add("GammaCurve", GammaCurve_Element.ToLinkField(context));
members.Add("FarColor", FarColor_Element.ToLinkField(context));
members.Add("NearColor", NearColor_Element.ToLinkField(context));
members.Add("FarTexture", FarTexture_Element.ToLinkReference(context));
members.Add("NearTexture", NearTexture_Element.ToLinkReference(context));
members.Add("FarTextureScale", FarTextureScale_Element.ToLinkField(context));
members.Add("FarTextureOffset", FarTextureOffset_Element.ToLinkField(context));
members.Add("NearTextureScale", NearTextureScale_Element.ToLinkField(context));
members.Add("NearTextureOffset", NearTextureOffset_Element.ToLinkField(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("UseVertexColors", UseVertexColors_Element.ToLinkField(context));
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("AlphaCutoff", AlphaCutoff_Element.ToLinkField(context));
members.Add("MaskTexture", MaskTexture_Element.ToLinkReference(context));
members.Add("MaskScale", MaskScale_Element.ToLinkField(context));
members.Add("MaskOffset", MaskOffset_Element.ToLinkField(context));
members.Add("MaskMode", MaskMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
members.Add("PolarUVmapping", PolarUVmapping_Element.ToLinkField(context));
members.Add("PolarPower", PolarPower_Element.ToLinkField(context));
}

}
}
