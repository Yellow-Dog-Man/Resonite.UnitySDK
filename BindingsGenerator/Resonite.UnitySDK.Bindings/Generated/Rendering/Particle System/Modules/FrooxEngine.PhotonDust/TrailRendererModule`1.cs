
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.TrailRendererModule<>
// Generated on: čtvrtek 26. února 2026 12:28:04
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.TrailRendererModule<>")]
public abstract partial class TrailRendererModule<M> : global::FrooxEngine.PhotonDust.ParticleSystemRendererModule<M,global::System.Object>
	

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::Renderite.Shared.TrailTextureMode TextureMode { get => TextureMode_Element.Data; set => TextureMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TrailTextureMode>, global::Renderite.Shared.TrailTextureMode> TextureMode_Element = new();
public global::Renderite.Shared.MotionVectorMode MotionVectorMode { get => MotionVectorMode_Element.Data; set => MotionVectorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.MotionVectorMode>, global::Renderite.Shared.MotionVectorMode> MotionVectorMode_Element = new();
public global::System.Boolean GenerateLightingData { get => GenerateLightingData_Element.Data; set => GenerateLightingData_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GenerateLightingData_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("TextureMode", TextureMode_Element.ToLinkField(context));
members.Add("MotionVectorMode", MotionVectorMode_Element.ToLinkField(context));
members.Add("GenerateLightingData", GenerateLightingData_Element.ToLinkField(context));
}

}
}
