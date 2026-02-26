
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OverlayUnlitMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OverlayUnlitMaterial")]
public partial class OverlayUnlitMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX BehindTintColor { get => BehindTintColor_Element.Data; set => BehindTintColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BehindTintColor_Element = new();
public UnityEngine.ColorX FrontTintColor { get => FrontTintColor_Element.Data; set => FrontTintColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FrontTintColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindTexture { get => BehindTexture_Element.Data; set => BehindTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> BehindTexture_Element = new();
public UnityEngine.Vector2 BehindTextureScale { get => BehindTextureScale_Element.Data; set => BehindTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindTextureScale_Element = new();
public UnityEngine.Vector2 BehindTextureOffset { get => BehindTextureOffset_Element.Data; set => BehindTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> BehindTextureOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontTexture { get => FrontTexture_Element.Data; set => FrontTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> FrontTexture_Element = new();
public UnityEngine.Vector2 FrontTextureScale { get => FrontTextureScale_Element.Data; set => FrontTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontTextureScale_Element = new();
public UnityEngine.Vector2 FrontTextureOffset { get => FrontTextureOffset_Element.Data; set => FrontTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FrontTextureOffset_Element = new();
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
public global::System.Boolean PolarUVmapping { get => PolarUVmapping_Element.Data; set => PolarUVmapping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PolarUVmapping_Element = new();
public global::System.Single PolarPower { get => PolarPower_Element.Data; set => PolarPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PolarPower_Element = new();
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
members.Add("BehindTintColor", BehindTintColor_Element.Data.ToResoniteLinkField());
members.Add("FrontTintColor", FrontTintColor_Element.Data.ToResoniteLinkField());
members.Add("BehindTexture", BehindTexture_Element.Data.ToResoniteReference(context));
members.Add("BehindTextureScale", BehindTextureScale_Element.Data.ToResoniteLinkField());
members.Add("BehindTextureOffset", BehindTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("FrontTexture", FrontTexture_Element.Data.ToResoniteReference(context));
members.Add("FrontTextureScale", FrontTextureScale_Element.Data.ToResoniteLinkField());
members.Add("FrontTextureOffset", FrontTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff_Element.Data.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors_Element.Data.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace_Element.Data.ToResoniteLinkField());
members.Add("Sidedness", Sidedness_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping_Element.Data.ToResoniteLinkField());
members.Add("PolarPower", PolarPower_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
