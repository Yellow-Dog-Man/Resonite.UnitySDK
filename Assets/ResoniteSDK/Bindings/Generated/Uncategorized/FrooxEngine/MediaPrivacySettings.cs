
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MediaPrivacySettings
// Generated on: čtvrtek 19. února 2026 8:00:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MediaPrivacySettings")]
public partial class MediaPrivacySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MediaPrivacySettings>

{
    public global::System.Boolean MediaMetadataOptOut;
public global::System.Boolean HideInScreenshots;
public global::System.Boolean StripImageFileMetadata;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MediaMetadataOptOut", MediaMetadataOptOut.ToResoniteLinkField());
members.Add("HideInScreenshots", HideInScreenshots.ToResoniteLinkField());
members.Add("StripImageFileMetadata", StripImageFileMetadata.ToResoniteLinkField());
}

}
}
