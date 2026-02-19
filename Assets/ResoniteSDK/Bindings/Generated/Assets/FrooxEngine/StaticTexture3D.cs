
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTexture3D
// Generated on: čtvrtek 19. února 2026 7:58:49
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticTexture3D")]
public partial class StaticTexture3D : global::FrooxEngine.StaticTextureProvider<global::FrooxEngine.Texture3D,global::Elements.Assets.Bitmap3D,global::Elements.Assets.VolumeMetadata,global::FrooxEngine.Texture3DVariantDescriptor>, global::FrooxEngine.ITexture3DProvider

{
    public global::Renderite.Shared.TextureWrapMode WrapModeU;
public global::Renderite.Shared.TextureWrapMode WrapModeV;
public global::Renderite.Shared.TextureWrapMode WrapModeW;
public global::System.Boolean Readable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WrapModeU", WrapModeU.ToResoniteLinkField());
members.Add("WrapModeV", WrapModeV.ToResoniteLinkField());
members.Add("WrapModeW", WrapModeW.ToResoniteLinkField());
members.Add("Readable", Readable.ToResoniteLinkField());
}

}
}
