
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StorageUsageStatus
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StorageUsageStatus")]
public partial class StorageUsageStatus : global::FrooxEngine.Component

{
    public global::System.String OwnerId { get => OwnerId_Element.Data; set => OwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OwnerId_Element = new();
public global::System.Boolean GroupMemberQuota { get => GroupMemberQuota_Element.Data; set => GroupMemberQuota_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GroupMemberQuota_Element = new();
public global::System.Boolean HasValidData { get => HasValidData_Element.Data; set => HasValidData_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasValidData_Element = new();
public global::System.Int64 StorageBytes { get => StorageBytes_Element.Data; set => StorageBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> StorageBytes_Element = new();
public global::System.Int64 FullStorageBytes { get => FullStorageBytes_Element.Data; set => FullStorageBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> FullStorageBytes_Element = new();
public global::System.Int64 ShareableStorageBytes { get => ShareableStorageBytes_Element.Data; set => ShareableStorageBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> ShareableStorageBytes_Element = new();
public global::System.Int64 SharedStorageBytes { get => SharedStorageBytes_Element.Data; set => SharedStorageBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> SharedStorageBytes_Element = new();
public global::System.Int64 UsageBytes { get => UsageBytes_Element.Data; set => UsageBytes_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> UsageBytes_Element = new();
public global::System.Single UsageRatio { get => UsageRatio_Element.Data; set => UsageRatio_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> UsageRatio_Element = new();
public global::System.String StorageString { get => StorageString_Element.Data; set => StorageString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> StorageString_Element = new();
public global::System.String FullStorageString { get => FullStorageString_Element.Data; set => FullStorageString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> FullStorageString_Element = new();
public global::System.String ShareableStorageString { get => ShareableStorageString_Element.Data; set => ShareableStorageString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> ShareableStorageString_Element = new();
public global::System.String SharedStorageString { get => SharedStorageString_Element.Data; set => SharedStorageString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> SharedStorageString_Element = new();
public global::System.String UsageString { get => UsageString_Element.Data; set => UsageString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> UsageString_Element = new();
public global::System.String RatioString { get => RatioString_Element.Data; set => RatioString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> RatioString_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerId", OwnerId_Element.ToLinkField(context));
members.Add("GroupMemberQuota", GroupMemberQuota_Element.ToLinkField(context));
members.Add("HasValidData", HasValidData_Element.ToLinkField(context));
members.Add("StorageBytes", StorageBytes_Element.ToLinkField(context));
members.Add("FullStorageBytes", FullStorageBytes_Element.ToLinkField(context));
members.Add("ShareableStorageBytes", ShareableStorageBytes_Element.ToLinkField(context));
members.Add("SharedStorageBytes", SharedStorageBytes_Element.ToLinkField(context));
members.Add("UsageBytes", UsageBytes_Element.ToLinkField(context));
members.Add("UsageRatio", UsageRatio_Element.ToLinkField(context));
members.Add("StorageString", StorageString_Element.ToLinkField(context));
members.Add("FullStorageString", FullStorageString_Element.ToLinkField(context));
members.Add("ShareableStorageString", ShareableStorageString_Element.ToLinkField(context));
members.Add("SharedStorageString", SharedStorageString_Element.ToLinkField(context));
members.Add("UsageString", UsageString_Element.ToLinkField(context));
members.Add("RatioString", RatioString_Element.ToLinkField(context));
}

}
}
