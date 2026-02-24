
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureQualitySettings
// Generated on: úterý 24. února 2026 18:20:29
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.TextureSizeRatio TextureSizeRatio;
public global::FrooxEngine.TextureSizeLimit TextureSizeLimit;
public global::System.Int32 MinimumTextureSize;
public global::Renderite.Shared.TextureFilterMode DefaultFilterMode;
public global::System.Int32 AnisotropicLevel;
public global::System.Boolean UseAnisotropicLevel;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureSizeRatio", TextureSizeRatio.ToResoniteLinkField());
members.Add("TextureSizeLimit", TextureSizeLimit.ToResoniteLinkField());
members.Add("MinimumTextureSize", MinimumTextureSize.ToResoniteLinkField());
members.Add("DefaultFilterMode", DefaultFilterMode.ToResoniteLinkField());
members.Add("AnisotropicLevel", AnisotropicLevel.ToResoniteLinkField());
members.Add("UseAnisotropicLevel", UseAnisotropicLevel.ToResoniteLinkField());
}

}
}
