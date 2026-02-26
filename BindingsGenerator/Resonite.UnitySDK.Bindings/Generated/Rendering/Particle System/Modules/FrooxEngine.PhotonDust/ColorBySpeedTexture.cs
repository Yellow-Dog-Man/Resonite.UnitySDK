
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedTexture
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single MinSpeed { get => MinSpeed_Element.Data; set => MinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSpeed_Element = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public global::Elements.Assets.WrapMode U_WrapMode { get => U_WrapMode_Element.Data; set => U_WrapMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.WrapMode>, global::Elements.Assets.WrapMode> U_WrapMode_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Texture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinSpeed", MinSpeed_Element.ToLinkField(context));
members.Add("MaxSpeed", MaxSpeed_Element.ToLinkField(context));
members.Add("U_WrapMode", U_WrapMode_Element.ToLinkField(context));
members.Add("Texture", Texture_Element.ToLinkReference(context));
}

}
}
