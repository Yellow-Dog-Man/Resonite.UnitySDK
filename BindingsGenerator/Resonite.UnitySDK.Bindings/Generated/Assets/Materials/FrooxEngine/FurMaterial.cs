
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FurMaterial
// Generated on: čtvrtek 26. února 2026 10:03:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FurMaterial")]
public partial class FurMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public UnityEngine.ColorX SpecularColor { get => SpecularColor_Element.Data; set => SpecularColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpecularColor_Element = new();
public global::System.Single Shininess { get => Shininess_Element.Data; set => Shininess_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Shininess_Element = new();
public global::System.Single Gloss { get => Gloss_Element.Data; set => Gloss_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Gloss_Element = new();
public UnityEngine.ColorX RimColor { get => RimColor_Element.Data; set => RimColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> RimColor_Element = new();
public global::System.Single RimPower { get => RimPower_Element.Data; set => RimPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RimPower_Element = new();
public global::System.Single FurLength { get => FurLength_Element.Data; set => FurLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FurLength_Element = new();
public global::System.Single FurHardness { get => FurHardness_Element.Data; set => FurHardness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FurHardness_Element = new();
public global::System.Single FurThinness { get => FurThinness_Element.Data; set => FurThinness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FurThinness_Element = new();
public global::System.Single FurShading { get => FurShading_Element.Data; set => FurShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FurShading_Element = new();
public global::System.Single FurColoring { get => FurColoring_Element.Data; set => FurColoring_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FurColoring_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Base { get => Base_Element.Data; set => Base_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Base_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Noise { get => Noise_Element.Data; set => Noise_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Noise_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public UnityEngine.Vector4 ForceGlobal { get => ForceGlobal_Element.Data; set => ForceGlobal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> ForceGlobal_Element = new();
public UnityEngine.Vector4 ForceLocal { get => ForceLocal_Element.Data; set => ForceLocal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4>, UnityEngine.Vector4> ForceLocal_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("SpecularColor", SpecularColor_Element.Data.ToResoniteLinkField());
members.Add("Shininess", Shininess_Element.Data.ToResoniteLinkField());
members.Add("Gloss", Gloss_Element.Data.ToResoniteLinkField());
members.Add("RimColor", RimColor_Element.Data.ToResoniteLinkField());
members.Add("RimPower", RimPower_Element.Data.ToResoniteLinkField());
members.Add("FurLength", FurLength_Element.Data.ToResoniteLinkField());
members.Add("FurHardness", FurHardness_Element.Data.ToResoniteLinkField());
members.Add("FurThinness", FurThinness_Element.Data.ToResoniteLinkField());
members.Add("FurShading", FurShading_Element.Data.ToResoniteLinkField());
members.Add("FurColoring", FurColoring_Element.Data.ToResoniteLinkField());
members.Add("Base", Base_Element.Data.ToResoniteReference(context));
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("Noise", Noise_Element.Data.ToResoniteReference(context));
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff_Element.Data.ToResoniteLinkField());
members.Add("ForceGlobal", ForceGlobal_Element.Data.ToResoniteLinkField());
members.Add("ForceLocal", ForceLocal_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
