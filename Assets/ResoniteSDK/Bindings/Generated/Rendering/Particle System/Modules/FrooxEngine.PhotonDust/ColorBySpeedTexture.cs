
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedTexture
// Generated on: pátek 13. února 2026 23:23:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedTexture")]
public partial class ColorBySpeedTexture : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single MinSpeed;
public global::System.Single MaxSpeed;
public global::Elements.Assets.WrapMode U_WrapMode;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("U_WrapMode", U_WrapMode.ToResoniteLinkField());
members.Add("Texture", new ResoniteLink.Reference() { });
}

}
}
