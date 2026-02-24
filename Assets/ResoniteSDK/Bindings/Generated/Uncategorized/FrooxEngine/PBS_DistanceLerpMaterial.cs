
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DistanceLerpMaterial
// Generated on: úterý 24. února 2026 18:17:35
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX AlbedoColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture;
public UnityEngine.ColorX EmissiveColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalScale;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap;
public UnityEngine.Vector3 GridSize;
public UnityEngine.Vector3 GridOffset;
public global::System.Single DisplaceFrom;
public global::System.Single DisplaceTo;
public global::System.Single DisplaceMagnitudeFrom;
public global::System.Single DisplaceMagnitudeTo;
public global::System.Single EmissionFrom;
public global::System.Single EmissionTo;
public UnityEngine.ColorX EmissionColorFrom;
public UnityEngine.ColorX EmissionColorTo;
public global::System.Nullable<UnityEngine.Vector3> OverrideDisplacementDirection;
public global::System.Boolean LocalSpace;
public System.Collections.Generic.List<global::FrooxEngine.PBS_DistanceLerpMaterial.Point> Points;
public global::FrooxEngine.Culling Culling;
public global::System.Boolean Transparent;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalScale", NormalScale.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap.ToResoniteReference(context));
members.Add("GridSize", GridSize.ToResoniteLinkField());
members.Add("GridOffset", GridOffset.ToResoniteLinkField());
members.Add("DisplaceFrom", DisplaceFrom.ToResoniteLinkField());
members.Add("DisplaceTo", DisplaceTo.ToResoniteLinkField());
members.Add("DisplaceMagnitudeFrom", DisplaceMagnitudeFrom.ToResoniteLinkField());
members.Add("DisplaceMagnitudeTo", DisplaceMagnitudeTo.ToResoniteLinkField());
members.Add("EmissionFrom", EmissionFrom.ToResoniteLinkField());
members.Add("EmissionTo", EmissionTo.ToResoniteLinkField());
members.Add("EmissionColorFrom", EmissionColorFrom.ToResoniteLinkField());
members.Add("EmissionColorTo", EmissionColorTo.ToResoniteLinkField());
members.Add("OverrideDisplacementDirection", OverrideDisplacementDirection.ToResoniteLinkField());
members.Add("LocalSpace", LocalSpace.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("Transparent", Transparent.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
