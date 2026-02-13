
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.BillboardParticleRenderer
// Generated on: pátek 13. února 2026 23:23:06
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::Renderite.Shared.BillboardAlignment Alignment;
public global::System.Single MinBillboardScreenSize;
public global::System.Single MaxBillboardScreenSize;
public global::Renderite.Shared.MotionVectorMode MotionVectorMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Alignment", Alignment.ToResoniteLinkField());
members.Add("MinBillboardScreenSize", MinBillboardScreenSize.ToResoniteLinkField());
members.Add("MaxBillboardScreenSize", MaxBillboardScreenSize.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode.ToResoniteLinkField());
}

}
}
