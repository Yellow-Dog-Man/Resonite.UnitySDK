
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralCubemapBase
// Generated on: středa 25. února 2026 16:13:04
// Resonite version: 2026.2.25.455
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
    public global::Renderite.Shared.TextureFilterMode FilterMode;
public global::System.Int32 AnisotropicLevel;
public global::System.Single MipmapBias;
public global::Renderite.Shared.ColorProfile Profile;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
members.Add("AnisotropicLevel", AnisotropicLevel.ToResoniteLinkField());
members.Add("MipmapBias", MipmapBias.ToResoniteLinkField());
members.Add("Profile", Profile.ToResoniteLinkField());
}

}
}
