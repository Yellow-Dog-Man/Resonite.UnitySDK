
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetGatherSettings
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetGatherSettings")]
public partial class AssetGatherSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AssetGatherSettings>

{
    public global::System.Int32 MaxConcurrentAssetTransfers { get => MaxConcurrentAssetTransfers_Element.Data; set => MaxConcurrentAssetTransfers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxConcurrentAssetTransfers_Element = new();
public global::System.Int32 MaxConcurrentDownloads { get => MaxConcurrentDownloads_Element.Data; set => MaxConcurrentDownloads_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxConcurrentDownloads_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxConcurrentAssetTransfers", MaxConcurrentAssetTransfers_Element.ToLinkField(context));
members.Add("MaxConcurrentDownloads", MaxConcurrentDownloads_Element.ToLinkField(context));
}

}
}
