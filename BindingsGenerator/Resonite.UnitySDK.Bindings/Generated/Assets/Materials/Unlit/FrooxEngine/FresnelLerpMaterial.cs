
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FresnelLerpMaterial
// Generated on: čtvrtek 26. února 2026 10:03:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FresnelLerpMaterial")]
public partial class FresnelLerpMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Lerp_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> LerpTexture { get => LerpTexture_Element.Data; set => LerpTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> LerpTexture_Element = new();
public UnityEngine.Vector2 LerpTextureScale { get => LerpTextureScale_Element.Data; set => LerpTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LerpTextureScale_Element = new();
public UnityEngine.Vector2 LerpTextureOffset { get => LerpTextureOffset_Element.Data; set => LerpTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LerpTextureOffset_Element = new();
public global::System.Boolean LerpTexturePolarUV { get => LerpTexturePolarUV_Element.Data; set => LerpTexturePolarUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LerpTexturePolarUV_Element = new();
public global::System.Single LerpTexturePolarPower { get => LerpTexturePolarPower_Element.Data; set => LerpTexturePolarPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LerpTexturePolarPower_Element = new();
public global::System.Single Exponent0 { get => Exponent0_Element.Data; set => Exponent0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exponent0_Element = new();
public global::System.Single Exponent1 { get => Exponent1_Element.Data; set => Exponent1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exponent1_Element = new();
public global::System.Single GammaCurve { get => GammaCurve_Element.Data; set => GammaCurve_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GammaCurve_Element = new();
public UnityEngine.ColorX FarColor0 { get => FarColor0_Element.Data; set => FarColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FarColor0_Element = new();
public UnityEngine.ColorX NearColor0 { get => NearColor0_Element.Data; set => NearColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NearColor0_Element = new();
public UnityEngine.ColorX FarColor1 { get => FarColor1_Element.Data; set => FarColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FarColor1_Element = new();
public UnityEngine.ColorX NearColor1 { get => NearColor1_Element.Data; set => NearColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NearColor1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture0 { get => FarTexture0_Element.Data; set => FarTexture0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FarTexture0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture0 { get => NearTexture0_Element.Data; set => NearTexture0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NearTexture0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FarTexture1 { get => FarTexture1_Element.Data; set => FarTexture1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FarTexture1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NearTexture1 { get => NearTexture1_Element.Data; set => NearTexture1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NearTexture1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap0 { get => NormalMap0_Element.Data; set => NormalMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap1 { get => NormalMap1_Element.Data; set => NormalMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap1_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp_Element.Data.ToResoniteLinkField());
members.Add("LerpTexture", LerpTexture_Element.Data.ToResoniteReference(context));
members.Add("LerpTextureScale", LerpTextureScale_Element.Data.ToResoniteLinkField());
members.Add("LerpTextureOffset", LerpTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("LerpTexturePolarUV", LerpTexturePolarUV_Element.Data.ToResoniteLinkField());
members.Add("LerpTexturePolarPower", LerpTexturePolarPower_Element.Data.ToResoniteLinkField());
members.Add("Exponent0", Exponent0_Element.Data.ToResoniteLinkField());
members.Add("Exponent1", Exponent1_Element.Data.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve_Element.Data.ToResoniteLinkField());
members.Add("FarColor0", FarColor0_Element.Data.ToResoniteLinkField());
members.Add("NearColor0", NearColor0_Element.Data.ToResoniteLinkField());
members.Add("FarColor1", FarColor1_Element.Data.ToResoniteLinkField());
members.Add("NearColor1", NearColor1_Element.Data.ToResoniteLinkField());
members.Add("FarTexture0", FarTexture0_Element.Data.ToResoniteReference(context));
members.Add("NearTexture0", NearTexture0_Element.Data.ToResoniteReference(context));
members.Add("FarTexture1", FarTexture1_Element.Data.ToResoniteReference(context));
members.Add("NearTexture1", NearTexture1_Element.Data.ToResoniteReference(context));
members.Add("NormalMap0", NormalMap0_Element.Data.ToResoniteReference(context));
members.Add("NormalMap1", NormalMap1_Element.Data.ToResoniteReference(context));
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("Sidedness", Sidedness_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
