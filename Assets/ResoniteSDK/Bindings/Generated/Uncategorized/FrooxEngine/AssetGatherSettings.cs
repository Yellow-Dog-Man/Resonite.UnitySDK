
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetGatherSettings
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::System.Int32 MaxConcurrentAssetTransfers;
public global::System.Int32 MaxConcurrentDownloads;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MaxConcurrentAssetTransfers", MaxConcurrentAssetTransfers.ToResoniteLinkField());
members.Add("MaxConcurrentDownloads", MaxConcurrentDownloads.ToResoniteLinkField());
}

}
}
