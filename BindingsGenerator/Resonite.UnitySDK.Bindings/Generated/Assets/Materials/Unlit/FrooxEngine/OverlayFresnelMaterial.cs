
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OverlayFresnelMaterial
// Generated on: čtvrtek 26. února 2026 15:07:54
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OverlayFresnelMaterial")]
public partial class OverlayFresnelMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Exponent { get => Exponent_Element.Data; set => Exponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exponent_Element = new();
public global::System.Single GammaCurve { get => GammaCurve_Element.Data; set => GammaCurve_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GammaCurve_Element = new();
public UnityEngine.ColorX BehindFarColor { get => BehindFarColor_Element.Data; set => BehindFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BehindFarColor_Element = new();
public UnityEngine.ColorX BehindNearColor { get => BehindNearColor_Element.Data; set => BehindNearColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BehindNearColor_Element = new();
public UnityEngine.ColorX FrontFarColor { get => FrontFarColor_Element.Data; set => FrontFarColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FrontFarColor_Element = new();
public UnityEngine.ColorX FrontNearColor { get => FrontNearColor_Element.Data; set => FrontNearColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FrontNearColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindFarTexture { get => BehindFarTexture_Element.Data; set => BehindFarTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> BehindFarTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindNearTexture { get => BehindNearTexture_Element.Data; set => BehindNearTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> BehindNearTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontFarTexture { get => FrontFarTexture_Element.Data; set => FrontFarTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FrontFarTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontNearTexture { get => FrontNearTexture_Element.Data; set => FrontNearTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FrontNearTexture_Element = new();
public UnityEngine.Vector2 BehindFarTextureScale { get => BehindFarTextureScale_Element.Data; set => BehindFarTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindFarTextureScale_Element = new();
public UnityEngine.Vector2 BehindFarTextureOffset { get => BehindFarTextureOffset_Element.Data; set => BehindFarTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindFarTextureOffset_Element = new();
public UnityEngine.Vector2 BehindNearTextureScale { get => BehindNearTextureScale_Element.Data; set => BehindNearTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindNearTextureScale_Element = new();
public UnityEngine.Vector2 BehindNearTextureOffset { get => BehindNearTextureOffset_Element.Data; set => BehindNearTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindNearTextureOffset_Element = new();
public UnityEngine.Vector2 FrontFarTextureScale { get => FrontFarTextureScale_Element.Data; set => FrontFarTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontFarTextureScale_Element = new();
public UnityEngine.Vector2 FrontFarTextureOffset { get => FrontFarTextureOffset_Element.Data; set => FrontFarTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontFarTextureOffset_Element = new();
public UnityEngine.Vector2 FrontNearTextureScale { get => FrontNearTextureScale_Element.Data; set => FrontNearTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontNearTextureScale_Element = new();
public UnityEngine.Vector2 FrontNearTextureOffset { get => FrontNearTextureOffset_Element.Data; set => FrontNearTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontNearTextureOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
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
members.Add("BehindFarColor", BehindFarColor_Element.ToLinkField(context));
members.Add("BehindNearColor", BehindNearColor_Element.ToLinkField(context));
members.Add("FrontFarColor", FrontFarColor_Element.ToLinkField(context));
members.Add("FrontNearColor", FrontNearColor_Element.ToLinkField(context));
members.Add("BehindFarTexture", BehindFarTexture_Element.ToLinkReference(context));
members.Add("BehindNearTexture", BehindNearTexture_Element.ToLinkReference(context));
members.Add("FrontFarTexture", FrontFarTexture_Element.ToLinkReference(context));
members.Add("FrontNearTexture", FrontNearTexture_Element.ToLinkReference(context));
members.Add("BehindFarTextureScale", BehindFarTextureScale_Element.ToLinkField(context));
members.Add("BehindFarTextureOffset", BehindFarTextureOffset_Element.ToLinkField(context));
members.Add("BehindNearTextureScale", BehindNearTextureScale_Element.ToLinkField(context));
members.Add("BehindNearTextureOffset", BehindNearTextureOffset_Element.ToLinkField(context));
members.Add("FrontFarTextureScale", FrontFarTextureScale_Element.ToLinkField(context));
members.Add("FrontFarTextureOffset", FrontFarTextureOffset_Element.ToLinkField(context));
members.Add("FrontNearTextureScale", FrontNearTextureScale_Element.ToLinkField(context));
members.Add("FrontNearTextureOffset", FrontNearTextureOffset_Element.ToLinkField(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("PolarUVmapping", PolarUVmapping_Element.ToLinkField(context));
members.Add("PolarPower", PolarPower_Element.ToLinkField(context));
}

}
}
