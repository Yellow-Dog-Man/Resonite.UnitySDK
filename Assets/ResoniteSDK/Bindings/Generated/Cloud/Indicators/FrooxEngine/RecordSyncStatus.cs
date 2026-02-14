
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RecordSyncStatus
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RecordSyncStatus")]
public partial class RecordSyncStatus : global::FrooxEngine.Component

{
    public global::System.Int32 RecordQueueCount;
public global::System.Int32 AssetVariantQueueCount;
public global::System.Single CurrentTaskProgress;
public global::System.String LastError;
public global::System.String StatusMessage;
public UnityEngine.ColorX FullySyncedColor;
public UnityEngine.ColorX ErrorColor;
public UnityEngine.ColorX SyncingRecordsColor;
public UnityEngine.ColorX UploadingAssetVariantsColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecordQueueCount", RecordQueueCount.ToResoniteLinkField());
members.Add("AssetVariantQueueCount", AssetVariantQueueCount.ToResoniteLinkField());
members.Add("CurrentTaskProgress", CurrentTaskProgress.ToResoniteLinkField());
members.Add("LastError", LastError.ToResoniteLinkField());
members.Add("StatusMessage", StatusMessage.ToResoniteLinkField());
members.Add("FullySyncedColor", FullySyncedColor.ToResoniteLinkField());
members.Add("ErrorColor", ErrorColor.ToResoniteLinkField());
members.Add("SyncingRecordsColor", SyncingRecordsColor.ToResoniteLinkField());
members.Add("UploadingAssetVariantsColor", UploadingAssetVariantsColor.ToResoniteLinkField());
}

}
}
