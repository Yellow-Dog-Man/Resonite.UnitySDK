
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorFromTexture3D
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorFromTexture3D")]
public partial class ColorFromTexture3D : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Texture3D { get => Texture3D_Element.Data; set => Texture3D_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> Texture3D_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture3D", Texture3D_Element.ToLinkReference(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
}

}
}
