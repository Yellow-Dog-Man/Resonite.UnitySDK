
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MediaPrivacySettings
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MediaPrivacySettings")]
public partial class MediaPrivacySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MediaPrivacySettings>

{
    public global::System.Boolean MediaMetadataOptOut { get => MediaMetadataOptOut_Element.Data; set => MediaMetadataOptOut_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MediaMetadataOptOut_Element = new();
public global::System.Boolean HideInScreenshots { get => HideInScreenshots_Element.Data; set => HideInScreenshots_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HideInScreenshots_Element = new();
public global::System.Boolean StripImageFileMetadata { get => StripImageFileMetadata_Element.Data; set => StripImageFileMetadata_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StripImageFileMetadata_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MediaMetadataOptOut", MediaMetadataOptOut_Element.Data.ToResoniteLinkField());
members.Add("HideInScreenshots", HideInScreenshots_Element.Data.ToResoniteLinkField());
members.Add("StripImageFileMetadata", StripImageFileMetadata_Element.Data.ToResoniteLinkField());
}

}
}
