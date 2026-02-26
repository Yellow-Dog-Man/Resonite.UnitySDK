
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnlitMaterial
// Generated on: čtvrtek 26. února 2026 10:03:35
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnlitMaterial")]
public partial class UnlitMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICommonMaterial, global::FrooxEngine.IStereoMaterial, global::FrooxEngine.IBillboardMaterial, global::FrooxEngine.IBlendModeMaterial, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.ColorX TintColor { get => TintColor_Element.Data; set => TintColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> TintColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture { get => MaskTexture_Element.Data; set => MaskTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MaskTexture_Element = new();
public UnityEngine.Vector2 MaskScale { get => MaskScale_Element.Data; set => MaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskScale_Element = new();
public UnityEngine.Vector2 MaskOffset { get => MaskOffset_Element.Data; set => MaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskOffset_Element = new();
public global::FrooxEngine.MaskTextureMode MaskMode { get => MaskMode_Element.Data; set => MaskMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MaskTextureMode>, global::FrooxEngine.MaskTextureMode> MaskMode_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public global::System.Boolean UseVertexColors { get => UseVertexColors_Element.Data; set => UseVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseVertexColors_Element = new();
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace { get => VertexColorInterpolationSpace_Element.Data; set => VertexColorInterpolationSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> VertexColorInterpolationSpace_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OffsetTexture { get => OffsetTexture_Element.Data; set => OffsetTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OffsetTexture_Element = new();
public UnityEngine.Vector2 OffsetMagnitude { get => OffsetMagnitude_Element.Data; set => OffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetMagnitude_Element = new();
public UnityEngine.Vector2 OffsetTextureScale { get => OffsetTextureScale_Element.Data; set => OffsetTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetTextureScale_Element = new();
public UnityEngine.Vector2 OffsetTextureOffset { get => OffsetTextureOffset_Element.Data; set => OffsetTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetTextureOffset_Element = new();
public global::System.Boolean PolarUVmapping { get => PolarUVmapping_Element.Data; set => PolarUVmapping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PolarUVmapping_Element = new();
public global::System.Single PolarPower { get => PolarPower_Element.Data; set => PolarPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PolarPower_Element = new();
public global::System.Boolean StereoTextureTransform { get => StereoTextureTransform_Element.Data; set => StereoTextureTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StereoTextureTransform_Element = new();
public UnityEngine.Vector2 RightEyeTextureScale { get => RightEyeTextureScale_Element.Data; set => RightEyeTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> RightEyeTextureScale_Element = new();
public UnityEngine.Vector2 RightEyeTextureOffset { get => RightEyeTextureOffset_Element.Data; set => RightEyeTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> RightEyeTextureOffset_Element = new();
public global::System.Boolean DecodeAsNormalMap { get => DecodeAsNormalMap_Element.Data; set => DecodeAsNormalMap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DecodeAsNormalMap_Element = new();
public global::System.Boolean UseBillboardGeometry { get => UseBillboardGeometry_Element.Data; set => UseBillboardGeometry_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseBillboardGeometry_Element = new();
public global::System.Boolean UsePerBillboardScale { get => UsePerBillboardScale_Element.Data; set => UsePerBillboardScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UsePerBillboardScale_Element = new();
public global::System.Boolean UsePerBillboardRotation { get => UsePerBillboardRotation_Element.Data; set => UsePerBillboardRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UsePerBillboardRotation_Element = new();
public global::System.Boolean UsePerBillboardUV { get => UsePerBillboardUV_Element.Data; set => UsePerBillboardUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UsePerBillboardUV_Element = new();
public UnityEngine.Vector2 BillboardSize { get => BillboardSize_Element.Data; set => BillboardSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BillboardSize_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _unlit { get => _unlit_Element.Data; set => _unlit_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _unlit_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _unlitBillboard { get => _unlitBillboard_Element.Data; set => _unlitBillboard_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _unlitBillboard_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TintColor", TintColor_Element.Data.ToResoniteLinkField());
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("MaskTexture", MaskTexture_Element.Data.ToResoniteReference(context));
members.Add("MaskScale", MaskScale_Element.Data.ToResoniteLinkField());
members.Add("MaskOffset", MaskOffset_Element.Data.ToResoniteLinkField());
members.Add("MaskMode", MaskMode_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff_Element.Data.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors_Element.Data.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace_Element.Data.ToResoniteLinkField());
members.Add("Sidedness", Sidedness_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("OffsetTexture", OffsetTexture_Element.Data.ToResoniteReference(context));
members.Add("OffsetMagnitude", OffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("OffsetTextureScale", OffsetTextureScale_Element.Data.ToResoniteLinkField());
members.Add("OffsetTextureOffset", OffsetTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping_Element.Data.ToResoniteLinkField());
members.Add("PolarPower", PolarPower_Element.Data.ToResoniteLinkField());
members.Add("StereoTextureTransform", StereoTextureTransform_Element.Data.ToResoniteLinkField());
members.Add("RightEyeTextureScale", RightEyeTextureScale_Element.Data.ToResoniteLinkField());
members.Add("RightEyeTextureOffset", RightEyeTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("DecodeAsNormalMap", DecodeAsNormalMap_Element.Data.ToResoniteLinkField());
members.Add("UseBillboardGeometry", UseBillboardGeometry_Element.Data.ToResoniteLinkField());
members.Add("UsePerBillboardScale", UsePerBillboardScale_Element.Data.ToResoniteLinkField());
members.Add("UsePerBillboardRotation", UsePerBillboardRotation_Element.Data.ToResoniteLinkField());
members.Add("UsePerBillboardUV", UsePerBillboardUV_Element.Data.ToResoniteLinkField());
members.Add("BillboardSize", BillboardSize_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
members.Add("_unlit", _unlit_Element.Data.ToResoniteReference(context));
members.Add("_unlitBillboard", _unlitBillboard_Element.Data.ToResoniteReference(context));
}

}
}
