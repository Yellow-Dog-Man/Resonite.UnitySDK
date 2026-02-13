
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StorageUsageStatus
// Generated on: pátek 13. února 2026 23:21:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StorageUsageStatus")]
public partial class StorageUsageStatus : global::FrooxEngine.Component

{
    public global::System.String OwnerId;
public global::System.Boolean GroupMemberQuota;
public global::System.Boolean HasValidData;
public global::System.Int64 StorageBytes;
public global::System.Int64 FullStorageBytes;
public global::System.Int64 ShareableStorageBytes;
public global::System.Int64 SharedStorageBytes;
public global::System.Int64 UsageBytes;
public global::System.Single UsageRatio;
public global::System.String StorageString;
public global::System.String FullStorageString;
public global::System.String ShareableStorageString;
public global::System.String SharedStorageString;
public global::System.String UsageString;
public global::System.String RatioString;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OwnerId", OwnerId.ToResoniteLinkField());
members.Add("GroupMemberQuota", GroupMemberQuota.ToResoniteLinkField());
members.Add("HasValidData", HasValidData.ToResoniteLinkField());
members.Add("StorageBytes", StorageBytes.ToResoniteLinkField());
members.Add("FullStorageBytes", FullStorageBytes.ToResoniteLinkField());
members.Add("ShareableStorageBytes", ShareableStorageBytes.ToResoniteLinkField());
members.Add("SharedStorageBytes", SharedStorageBytes.ToResoniteLinkField());
members.Add("UsageBytes", UsageBytes.ToResoniteLinkField());
members.Add("UsageRatio", UsageRatio.ToResoniteLinkField());
members.Add("StorageString", StorageString.ToResoniteLinkField());
members.Add("FullStorageString", FullStorageString.ToResoniteLinkField());
members.Add("ShareableStorageString", ShareableStorageString.ToResoniteLinkField());
members.Add("SharedStorageString", SharedStorageString.ToResoniteLinkField());
members.Add("UsageString", UsageString.ToResoniteLinkField());
members.Add("RatioString", RatioString.ToResoniteLinkField());
}

}
}
