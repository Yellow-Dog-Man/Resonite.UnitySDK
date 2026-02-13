
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.TrailRendererModule<>
// Generated on: pátek 13. února 2026 5:52:22
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.TrailRendererModule<>")]
public abstract partial class TrailRendererModule<M> : global::FrooxEngine.PhotonDust.ParticleSystemRendererModule<M,global::System.Object>
	

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::Renderite.Shared.TrailTextureMode TextureMode;
public global::Renderite.Shared.MotionVectorMode MotionVectorMode;
public global::System.Boolean GenerateLightingData;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("TextureMode", TextureMode.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode.ToResoniteLinkField());
members.Add("GenerateLightingData", GenerateLightingData.ToResoniteLinkField());
}

}
}
