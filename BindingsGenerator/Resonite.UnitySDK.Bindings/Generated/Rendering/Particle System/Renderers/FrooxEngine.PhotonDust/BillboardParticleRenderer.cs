
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BillboardParticleRenderer
// Generated on: čtvrtek 26. února 2026 10:04:39
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.BillboardParticleRenderer")]
public partial class BillboardParticleRenderer : global::FrooxEngine.PhotonDust.ParticleRenderer<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::Renderite.Shared.BillboardAlignment Alignment { get => Alignment_Element.Data; set => Alignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BillboardAlignment>, global::Renderite.Shared.BillboardAlignment> Alignment_Element = new();
public global::System.Single MinBillboardScreenSize { get => MinBillboardScreenSize_Element.Data; set => MinBillboardScreenSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinBillboardScreenSize_Element = new();
public global::System.Single MaxBillboardScreenSize { get => MaxBillboardScreenSize_Element.Data; set => MaxBillboardScreenSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxBillboardScreenSize_Element = new();
public global::Renderite.Shared.MotionVectorMode MotionVectorMode { get => MotionVectorMode_Element.Data; set => MotionVectorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.MotionVectorMode>, global::Renderite.Shared.MotionVectorMode> MotionVectorMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.Data.ToResoniteReference(context));
members.Add("Alignment", Alignment_Element.Data.ToResoniteLinkField());
members.Add("MinBillboardScreenSize", MinBillboardScreenSize_Element.Data.ToResoniteLinkField());
members.Add("MaxBillboardScreenSize", MaxBillboardScreenSize_Element.Data.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode_Element.Data.ToResoniteLinkField());
}

}
}
