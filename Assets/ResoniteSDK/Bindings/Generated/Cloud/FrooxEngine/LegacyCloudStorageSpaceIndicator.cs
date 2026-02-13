
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCloudStorageSpaceIndicator
// Generated on: pátek 13. února 2026 5:51:10
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCloudStorageSpaceIndicator")]
public partial class LegacyCloudStorageSpaceIndicator : global::FrooxEngine.Component

{
    public global::FrooxEngine.StorageUsageStatus Source;
public UnityEngine.ColorX ContainerColor;
public UnityEngine.ColorX UsedColor;
public UnityEngine.ColorX LowSpaceColor;
public UnityEngine.ColorX CriticalSpaceColor;
public global::System.Single LowSpaceThreshold;
public global::System.Single CriticalSpaceThreshold;
public global::FrooxEngine.TextRenderer _ownerLabel;
public global::FrooxEngine.TextRenderer _usageLabel;
public global::FrooxEngine.TextRenderer _percentLabel;
public global::FrooxEngine.LegacyProgressBar _progressBar;
public global::System.String __legacyOwnerId;
public global::System.Boolean __legacyMemberQuota;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("ContainerColor", ContainerColor.ToResoniteLinkField());
members.Add("UsedColor", UsedColor.ToResoniteLinkField());
members.Add("LowSpaceColor", LowSpaceColor.ToResoniteLinkField());
members.Add("CriticalSpaceColor", CriticalSpaceColor.ToResoniteLinkField());
members.Add("LowSpaceThreshold", LowSpaceThreshold.ToResoniteLinkField());
members.Add("CriticalSpaceThreshold", CriticalSpaceThreshold.ToResoniteLinkField());
members.Add("_ownerLabel", new ResoniteLink.Reference() { });
members.Add("_usageLabel", new ResoniteLink.Reference() { });
members.Add("_percentLabel", new ResoniteLink.Reference() { });
members.Add("_progressBar", new ResoniteLink.Reference() { });
members.Add("__legacyOwnerId", __legacyOwnerId.ToResoniteLinkField());
members.Add("__legacyMemberQuota", __legacyMemberQuota.ToResoniteLinkField());
}

}
}
