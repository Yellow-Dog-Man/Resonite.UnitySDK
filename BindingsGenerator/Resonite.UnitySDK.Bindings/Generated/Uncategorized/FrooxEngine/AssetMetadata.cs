
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMetadata
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetMetadata")]
public partial class AssetMetadata : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::System.String LocationName { get => LocationName_Element.Data; set => LocationName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> LocationName_Element = new();
public System.Uri LocationURL { get => LocationURL_Element.Data; set => LocationURL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> LocationURL_Element = new();
public global::FrooxEngine.UserRef LocationHost = new();
public global::System.Nullable<global::SkyFrost.Base.SessionAccessLevel> LocationAccessLevel { get => LocationAccessLevel_Element.Data; set => LocationAccessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::SkyFrost.Base.SessionAccessLevel>>, global::System.Nullable<global::SkyFrost.Base.SessionAccessLevel>> LocationAccessLevel_Element = new();
public global::System.Nullable<global::System.Boolean> LocationHiddenFromListing { get => LocationHiddenFromListing_Element.Data; set => LocationHiddenFromListing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> LocationHiddenFromListing_Element = new();
public global::System.DateTime TimeTaken { get => TimeTaken_Element.Data; set => TimeTaken_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> TimeTaken_Element = new();
public global::FrooxEngine.UserRef TakenBy = new();
public UnityEngine.Vector3 TakenGlobalPosition { get => TakenGlobalPosition_Element.Data; set => TakenGlobalPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TakenGlobalPosition_Element = new();
public UnityEngine.Quaternion TakenGlobalRotation { get => TakenGlobalRotation_Element.Data; set => TakenGlobalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> TakenGlobalRotation_Element = new();
public UnityEngine.Vector3 TakenGlobalScale { get => TakenGlobalScale_Element.Data; set => TakenGlobalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TakenGlobalScale_Element = new();
public global::System.String AppVersion { get => AppVersion_Element.Data; set => AppVersion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AppVersion_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.AssetMetadata.UserInfo>, global::FrooxEngine.AssetMetadata.UserInfo> UserInfos = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> __legacyPresentUsers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocationName", LocationName_Element.ToLinkField(context));
members.Add("LocationURL", LocationURL_Element.ToLinkField(context));
members.Add("LocationHost", LocationHost.ToLinkSyncObject(context));
members.Add("LocationAccessLevel", LocationAccessLevel_Element.ToLinkField(context));
members.Add("LocationHiddenFromListing", LocationHiddenFromListing_Element.ToLinkField(context));
members.Add("TimeTaken", TimeTaken_Element.ToLinkField(context));
members.Add("TakenBy", TakenBy.ToLinkSyncObject(context));
members.Add("TakenGlobalPosition", TakenGlobalPosition_Element.ToLinkField(context));
members.Add("TakenGlobalRotation", TakenGlobalRotation_Element.ToLinkField(context));
members.Add("TakenGlobalScale", TakenGlobalScale_Element.ToLinkField(context));
members.Add("AppVersion", AppVersion_Element.ToLinkField(context));
members.Add("UserInfos", UserInfos.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("__legacyPresentUsers", __legacyPresentUsers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
