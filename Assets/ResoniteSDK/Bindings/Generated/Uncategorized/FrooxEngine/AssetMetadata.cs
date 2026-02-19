
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMetadata
// Generated on: čtvrtek 19. února 2026 7:58:56
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.String LocationName;
public System.Uri LocationURL;
public global::FrooxEngine.UserRef LocationHost;
public global::System.Nullable<global::SkyFrost.Base.SessionAccessLevel> LocationAccessLevel;
public global::System.Nullable<global::System.Boolean> LocationHiddenFromListing;
public global::System.DateTime TimeTaken;
public global::FrooxEngine.UserRef TakenBy;
public UnityEngine.Vector3 TakenGlobalPosition;
public UnityEngine.Quaternion TakenGlobalRotation;
public UnityEngine.Vector3 TakenGlobalScale;
public global::System.String AppVersion;
public System.Collections.Generic.List<global::FrooxEngine.AssetMetadata.UserInfo> UserInfos;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> __legacyPresentUsers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocationName", LocationName.ToResoniteLinkField());
members.Add("LocationURL", LocationURL.ToResoniteLinkField());
members.Add("LocationHost", new ResoniteLink.SyncObject() { Members = LocationHost.CollectMembers(context) });
members.Add("LocationAccessLevel", LocationAccessLevel.ToResoniteLinkField());
members.Add("LocationHiddenFromListing", LocationHiddenFromListing.ToResoniteLinkField());
members.Add("TimeTaken", TimeTaken.ToResoniteLinkField());
members.Add("TakenBy", new ResoniteLink.SyncObject() { Members = TakenBy.CollectMembers(context) });
members.Add("TakenGlobalPosition", TakenGlobalPosition.ToResoniteLinkField());
members.Add("TakenGlobalRotation", TakenGlobalRotation.ToResoniteLinkField());
members.Add("TakenGlobalScale", TakenGlobalScale.ToResoniteLinkField());
members.Add("AppVersion", AppVersion.ToResoniteLinkField());
members.Add("UserInfos", new ResoniteLink.SyncList()
{
    Elements = UserInfos.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("__legacyPresentUsers", new ResoniteLink.SyncList()
{
    Elements = __legacyPresentUsers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
