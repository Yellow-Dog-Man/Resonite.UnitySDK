
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureQualitySettings
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureQualitySettings")]
public partial class TextureQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TextureQualitySettings>

{
    public global::FrooxEngine.TextureSizeRatio TextureSizeRatio { get => TextureSizeRatio_Element.Data; set => TextureSizeRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TextureSizeRatio>, global::FrooxEngine.TextureSizeRatio> TextureSizeRatio_Element = new();
public global::FrooxEngine.TextureSizeLimit TextureSizeLimit { get => TextureSizeLimit_Element.Data; set => TextureSizeLimit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TextureSizeLimit>, global::FrooxEngine.TextureSizeLimit> TextureSizeLimit_Element = new();
public global::System.Int32 MinimumTextureSize { get => MinimumTextureSize_Element.Data; set => MinimumTextureSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MinimumTextureSize_Element = new();
public global::Renderite.Shared.TextureFilterMode DefaultFilterMode { get => DefaultFilterMode_Element.Data; set => DefaultFilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFilterMode>, global::Renderite.Shared.TextureFilterMode> DefaultFilterMode_Element = new();
public global::System.Int32 AnisotropicLevel { get => AnisotropicLevel_Element.Data; set => AnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AnisotropicLevel_Element = new();
public global::System.Boolean UseAnisotropicLevel { get => UseAnisotropicLevel_Element.Data; set => UseAnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseAnisotropicLevel_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureSizeRatio", TextureSizeRatio_Element.ToLinkField(context));
members.Add("TextureSizeLimit", TextureSizeLimit_Element.ToLinkField(context));
members.Add("MinimumTextureSize", MinimumTextureSize_Element.ToLinkField(context));
members.Add("DefaultFilterMode", DefaultFilterMode_Element.ToLinkField(context));
members.Add("AnisotropicLevel", AnisotropicLevel_Element.ToLinkField(context));
members.Add("UseAnisotropicLevel", UseAnisotropicLevel_Element.ToLinkField(context));
}

}
}
