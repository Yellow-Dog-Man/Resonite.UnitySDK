
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DistanceLerpMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DistanceLerpMaterial")]
public abstract partial class PBS_DistanceLerpMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.ICullingMaterial

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public UnityEngine.Vector3 GridSize { get => GridSize_Element.Data; set => GridSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GridSize_Element = new();
public UnityEngine.Vector3 GridOffset { get => GridOffset_Element.Data; set => GridOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GridOffset_Element = new();
public global::System.Single DisplaceFrom { get => DisplaceFrom_Element.Data; set => DisplaceFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplaceFrom_Element = new();
public global::System.Single DisplaceTo { get => DisplaceTo_Element.Data; set => DisplaceTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplaceTo_Element = new();
public global::System.Single DisplaceMagnitudeFrom { get => DisplaceMagnitudeFrom_Element.Data; set => DisplaceMagnitudeFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplaceMagnitudeFrom_Element = new();
public global::System.Single DisplaceMagnitudeTo { get => DisplaceMagnitudeTo_Element.Data; set => DisplaceMagnitudeTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplaceMagnitudeTo_Element = new();
public global::System.Single EmissionFrom { get => EmissionFrom_Element.Data; set => EmissionFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EmissionFrom_Element = new();
public global::System.Single EmissionTo { get => EmissionTo_Element.Data; set => EmissionTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EmissionTo_Element = new();
public UnityEngine.ColorX EmissionColorFrom { get => EmissionColorFrom_Element.Data; set => EmissionColorFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissionColorFrom_Element = new();
public UnityEngine.ColorX EmissionColorTo { get => EmissionColorTo_Element.Data; set => EmissionColorTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissionColorTo_Element = new();
public global::System.Nullable<UnityEngine.Vector3> OverrideDisplacementDirection { get => OverrideDisplacementDirection_Element.Data; set => OverrideDisplacementDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> OverrideDisplacementDirection_Element = new();
public global::System.Boolean LocalSpace { get => LocalSpace_Element.Data; set => LocalSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LocalSpace_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.PBS_DistanceLerpMaterial.Point>, global::FrooxEngine.PBS_DistanceLerpMaterial.Point> Points = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
public global::System.Boolean Transparent { get => Transparent_Element.Data; set => Transparent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Transparent_Element = new();
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
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap_Element.Data.ToResoniteReference(context));
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("NormalScale", NormalScale_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap_Element.Data.ToResoniteReference(context));
members.Add("GridSize", GridSize_Element.Data.ToResoniteLinkField());
members.Add("GridOffset", GridOffset_Element.Data.ToResoniteLinkField());
members.Add("DisplaceFrom", DisplaceFrom_Element.Data.ToResoniteLinkField());
members.Add("DisplaceTo", DisplaceTo_Element.Data.ToResoniteLinkField());
members.Add("DisplaceMagnitudeFrom", DisplaceMagnitudeFrom_Element.Data.ToResoniteLinkField());
members.Add("DisplaceMagnitudeTo", DisplaceMagnitudeTo_Element.Data.ToResoniteLinkField());
members.Add("EmissionFrom", EmissionFrom_Element.Data.ToResoniteLinkField());
members.Add("EmissionTo", EmissionTo_Element.Data.ToResoniteLinkField());
members.Add("EmissionColorFrom", EmissionColorFrom_Element.Data.ToResoniteLinkField());
members.Add("EmissionColorTo", EmissionColorTo_Element.Data.ToResoniteLinkField());
members.Add("OverrideDisplacementDirection", OverrideDisplacementDirection_Element.Data.ToResoniteLinkField());
members.Add("LocalSpace", LocalSpace_Element.Data.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Culling", Culling_Element.Data.ToResoniteLinkField());
members.Add("Transparent", Transparent_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
