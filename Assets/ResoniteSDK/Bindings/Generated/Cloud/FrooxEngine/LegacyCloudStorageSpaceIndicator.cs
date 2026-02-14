
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCloudStorageSpaceIndicator
// Generated on: sobota 14. února 2026 8:57:02
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("ContainerColor", ContainerColor.ToResoniteLinkField());
members.Add("UsedColor", UsedColor.ToResoniteLinkField());
members.Add("LowSpaceColor", LowSpaceColor.ToResoniteLinkField());
members.Add("CriticalSpaceColor", CriticalSpaceColor.ToResoniteLinkField());
members.Add("LowSpaceThreshold", LowSpaceThreshold.ToResoniteLinkField());
members.Add("CriticalSpaceThreshold", CriticalSpaceThreshold.ToResoniteLinkField());
members.Add("_ownerLabel", _ownerLabel.ToResoniteReference(context));
members.Add("_usageLabel", _usageLabel.ToResoniteReference(context));
members.Add("_percentLabel", _percentLabel.ToResoniteReference(context));
members.Add("_progressBar", _progressBar.ToResoniteReference(context));
members.Add("__legacyOwnerId", __legacyOwnerId.ToResoniteLinkField());
members.Add("__legacyMemberQuota", __legacyMemberQuota.ToResoniteLinkField());
}

}
}
