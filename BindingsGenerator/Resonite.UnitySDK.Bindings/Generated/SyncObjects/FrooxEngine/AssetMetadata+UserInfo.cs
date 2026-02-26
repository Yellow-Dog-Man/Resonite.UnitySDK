
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetMetadata+UserInfo
// Generated on: čtvrtek 26. února 2026 12:26:54
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.UserRef User = new();
public global::System.Boolean IsInVR { get => IsInVR_Element.Data; set => IsInVR_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsInVR_Element = new();
public global::System.Boolean IsPresent { get => IsPresent_Element.Data; set => IsPresent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPresent_Element = new();
public UnityEngine.Vector3 HeadPosition { get => HeadPosition_Element.Data; set => HeadPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HeadPosition_Element = new();
public UnityEngine.Quaternion HeadOrientation { get => HeadOrientation_Element.Data; set => HeadOrientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> HeadOrientation_Element = new();
public global::System.DateTime SessionJoinTimestamp { get => SessionJoinTimestamp_Element.Data; set => SessionJoinTimestamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> SessionJoinTimestamp_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToLinkSyncObject(context));
members.Add("IsInVR", IsInVR_Element.ToLinkField(context));
members.Add("IsPresent", IsPresent_Element.ToLinkField(context));
members.Add("HeadPosition", HeadPosition_Element.ToLinkField(context));
members.Add("HeadOrientation", HeadOrientation_Element.ToLinkField(context));
members.Add("SessionJoinTimestamp", SessionJoinTimestamp_Element.ToLinkField(context));
}

}
            }
}
