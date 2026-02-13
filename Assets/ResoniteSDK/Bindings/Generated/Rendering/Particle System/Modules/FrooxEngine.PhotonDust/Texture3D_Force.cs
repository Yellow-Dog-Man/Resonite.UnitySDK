
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.Texture3D_Force
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.Texture3D_Force")]
public partial class Texture3D_Force : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture3D;
public global::PhotonDust.ForceMode Mode;
public global::System.Single Strength;
public UnityEngine.Vector3 Scale;
public UnityEngine.Vector3 Offset;
public global::System.Single ColorBias;
public global::System.Single ColorScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture3D", new ResoniteLink.Reference() { });
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Strength", Strength.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("ColorBias", ColorBias.ToResoniteLinkField());
members.Add("ColorScale", ColorScale.ToResoniteLinkField());
}

}
}
