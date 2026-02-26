
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralCubemapBase
// Generated on: čtvrtek 26. února 2026 12:26:49
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralCubemapBase")]
public abstract partial class ProceduralCubemapBase : global::FrooxEngine.ProceduralAssetProvider<global::FrooxEngine.Cubemap>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>

{
    public global::Renderite.Shared.TextureFilterMode FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFilterMode>, global::Renderite.Shared.TextureFilterMode> FilterMode_Element = new();
public global::System.Int32 AnisotropicLevel { get => AnisotropicLevel_Element.Data; set => AnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AnisotropicLevel_Element = new();
public global::System.Single MipmapBias { get => MipmapBias_Element.Data; set => MipmapBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MipmapBias_Element = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
members.Add("AnisotropicLevel", AnisotropicLevel_Element.ToLinkField(context));
members.Add("MipmapBias", MipmapBias_Element.ToLinkField(context));
members.Add("Profile", Profile_Element.ToLinkField(context));
}

}
}
