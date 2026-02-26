
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticTexture3D
// Generated on: čtvrtek 26. února 2026 15:07:52
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::Renderite.Shared.TextureWrapMode WrapModeU { get => WrapModeU_Element.Data; set => WrapModeU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeU_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeV { get => WrapModeV_Element.Data; set => WrapModeV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeV_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeW { get => WrapModeW_Element.Data; set => WrapModeW_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeW_Element = new();
public global::System.Boolean Readable { get => Readable_Element.Data; set => Readable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Readable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WrapModeU", WrapModeU_Element.ToLinkField(context));
members.Add("WrapModeV", WrapModeV_Element.ToLinkField(context));
members.Add("WrapModeW", WrapModeW_Element.ToLinkField(context));
members.Add("Readable", Readable_Element.ToLinkField(context));
}

}
}
