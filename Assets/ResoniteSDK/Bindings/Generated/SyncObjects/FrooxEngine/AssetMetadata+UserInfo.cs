
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMetadata+UserInfo
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
    public partial class AssetMetadata
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetMetadata+UserInfo")]
public partial class UserInfo : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.UserRef User;
public global::System.Boolean IsInVR;
public global::System.Boolean IsPresent;
public UnityEngine.Vector3 HeadPosition;
public UnityEngine.Quaternion HeadOrientation;
public global::System.DateTime SessionJoinTimestamp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("IsInVR", IsInVR.ToResoniteLinkField());
members.Add("IsPresent", IsPresent.ToResoniteLinkField());
members.Add("HeadPosition", HeadPosition.ToResoniteLinkField());
members.Add("HeadOrientation", HeadOrientation.ToResoniteLinkField());
members.Add("SessionJoinTimestamp", SessionJoinTimestamp.ToResoniteLinkField());
}

}
            }
}
