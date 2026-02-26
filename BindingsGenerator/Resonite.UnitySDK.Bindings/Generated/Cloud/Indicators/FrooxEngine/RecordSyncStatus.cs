
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RecordSyncStatus
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RecordSyncStatus")]
public partial class RecordSyncStatus : global::FrooxEngine.Component

{
    public global::System.Int32 RecordQueueCount { get => RecordQueueCount_Element.Data; set => RecordQueueCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> RecordQueueCount_Element = new();
public global::System.Int32 AssetVariantQueueCount { get => AssetVariantQueueCount_Element.Data; set => AssetVariantQueueCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> AssetVariantQueueCount_Element = new();
public global::System.Single CurrentTaskProgress { get => CurrentTaskProgress_Element.Data; set => CurrentTaskProgress_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CurrentTaskProgress_Element = new();
public global::System.String LastError { get => LastError_Element.Data; set => LastError_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LastError_Element = new();
public global::System.String StatusMessage { get => StatusMessage_Element.Data; set => StatusMessage_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> StatusMessage_Element = new();
public UnityEngine.ColorX FullySyncedColor { get => FullySyncedColor_Element.Data; set => FullySyncedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FullySyncedColor_Element = new();
public UnityEngine.ColorX ErrorColor { get => ErrorColor_Element.Data; set => ErrorColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ErrorColor_Element = new();
public UnityEngine.ColorX SyncingRecordsColor { get => SyncingRecordsColor_Element.Data; set => SyncingRecordsColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SyncingRecordsColor_Element = new();
public UnityEngine.ColorX UploadingAssetVariantsColor { get => UploadingAssetVariantsColor_Element.Data; set => UploadingAssetVariantsColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> UploadingAssetVariantsColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecordQueueCount", RecordQueueCount_Element.ToLinkField(context));
members.Add("AssetVariantQueueCount", AssetVariantQueueCount_Element.ToLinkField(context));
members.Add("CurrentTaskProgress", CurrentTaskProgress_Element.ToLinkField(context));
members.Add("LastError", LastError_Element.ToLinkField(context));
members.Add("StatusMessage", StatusMessage_Element.ToLinkField(context));
members.Add("FullySyncedColor", FullySyncedColor_Element.ToLinkField(context));
members.Add("ErrorColor", ErrorColor_Element.ToLinkField(context));
members.Add("SyncingRecordsColor", SyncingRecordsColor_Element.ToLinkField(context));
members.Add("UploadingAssetVariantsColor", UploadingAssetVariantsColor_Element.ToLinkField(context));
}

}
}
