
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.Texture3D_Force
// Generated on: čtvrtek 26. února 2026 12:28:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.Texture3D_Force")]
public partial class Texture3D_Force : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture3D { get => Texture3D_Element.Data; set => Texture3D_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> Texture3D_Element = new();
public global::PhotonDust.ForceMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ForceMode>, global::PhotonDust.ForceMode> Mode_Element = new();
public global::System.Single Strength { get => Strength_Element.Data; set => Strength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Strength_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public global::System.Single ColorBias { get => ColorBias_Element.Data; set => ColorBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorBias_Element = new();
public global::System.Single ColorScale { get => ColorScale_Element.Data; set => ColorScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture3D", Texture3D_Element.ToLinkReference(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("Strength", Strength_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("ColorBias", ColorBias_Element.ToLinkField(context));
members.Add("ColorScale", ColorScale_Element.ToLinkField(context));
}

}
}
