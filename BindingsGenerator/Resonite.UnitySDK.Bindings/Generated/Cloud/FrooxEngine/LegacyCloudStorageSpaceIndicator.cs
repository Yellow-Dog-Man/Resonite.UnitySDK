
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCloudStorageSpaceIndicator
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCloudStorageSpaceIndicator")]
public partial class LegacyCloudStorageSpaceIndicator : global::FrooxEngine.Component

{
    public global::FrooxEngine.StorageUsageStatus Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.StorageUsageStatus>, global::FrooxEngine.StorageUsageStatus> Source_Element = new();
public UnityEngine.ColorX ContainerColor { get => ContainerColor_Element.Data; set => ContainerColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ContainerColor_Element = new();
public UnityEngine.ColorX UsedColor { get => UsedColor_Element.Data; set => UsedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> UsedColor_Element = new();
public UnityEngine.ColorX LowSpaceColor { get => LowSpaceColor_Element.Data; set => LowSpaceColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LowSpaceColor_Element = new();
public UnityEngine.ColorX CriticalSpaceColor { get => CriticalSpaceColor_Element.Data; set => CriticalSpaceColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CriticalSpaceColor_Element = new();
public global::System.Single LowSpaceThreshold { get => LowSpaceThreshold_Element.Data; set => LowSpaceThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LowSpaceThreshold_Element = new();
public global::System.Single CriticalSpaceThreshold { get => CriticalSpaceThreshold_Element.Data; set => CriticalSpaceThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CriticalSpaceThreshold_Element = new();
public global::FrooxEngine.TextRenderer _ownerLabel { get => _ownerLabel_Element.Data; set => _ownerLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _ownerLabel_Element = new();
public global::FrooxEngine.TextRenderer _usageLabel { get => _usageLabel_Element.Data; set => _usageLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _usageLabel_Element = new();
public global::FrooxEngine.TextRenderer _percentLabel { get => _percentLabel_Element.Data; set => _percentLabel_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _percentLabel_Element = new();
public global::FrooxEngine.LegacyProgressBar _progressBar { get => _progressBar_Element.Data; set => _progressBar_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyProgressBar>, global::FrooxEngine.LegacyProgressBar> _progressBar_Element = new();
public global::System.String __legacyOwnerId { get => __legacyOwnerId_Element.Data; set => __legacyOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> __legacyOwnerId_Element = new();
public global::System.Boolean __legacyMemberQuota { get => __legacyMemberQuota_Element.Data; set => __legacyMemberQuota_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyMemberQuota_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("ContainerColor", ContainerColor_Element.ToLinkField(context));
members.Add("UsedColor", UsedColor_Element.ToLinkField(context));
members.Add("LowSpaceColor", LowSpaceColor_Element.ToLinkField(context));
members.Add("CriticalSpaceColor", CriticalSpaceColor_Element.ToLinkField(context));
members.Add("LowSpaceThreshold", LowSpaceThreshold_Element.ToLinkField(context));
members.Add("CriticalSpaceThreshold", CriticalSpaceThreshold_Element.ToLinkField(context));
members.Add("_ownerLabel", _ownerLabel_Element.ToLinkReference(context));
members.Add("_usageLabel", _usageLabel_Element.ToLinkReference(context));
members.Add("_percentLabel", _percentLabel_Element.ToLinkReference(context));
members.Add("_progressBar", _progressBar_Element.ToLinkReference(context));
members.Add("__legacyOwnerId", __legacyOwnerId_Element.ToLinkField(context));
members.Add("__legacyMemberQuota", __legacyMemberQuota_Element.ToLinkField(context));
}

}
}
