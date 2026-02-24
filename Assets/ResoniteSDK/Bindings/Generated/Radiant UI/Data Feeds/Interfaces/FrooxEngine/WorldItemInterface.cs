
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldItemInterface
// Generated on: úterý 24. února 2026 18:20:02
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldItemInterface")]
public partial class WorldItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.String> WorldName;
public global::FrooxEngine.IField<global::System.String> Description;
public global::FrooxEngine.IField<System.Uri> ThumbnailUrl;
public global::FrooxEngine.IField<global::System.Int32> JoinedUsers;
public global::FrooxEngine.IField<global::System.Int32> ActiveUsers;
public global::FrooxEngine.IField<global::System.Boolean> IsHost;
public global::FrooxEngine.IField<global::System.Boolean> AwayKickEnabled;
public global::FrooxEngine.IField<global::System.TimeSpan> AwayKickInterval;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WorldName", WorldName.ToResoniteReference(context));
members.Add("Description", Description.ToResoniteReference(context));
members.Add("ThumbnailUrl", ThumbnailUrl.ToResoniteReference(context));
members.Add("JoinedUsers", JoinedUsers.ToResoniteReference(context));
members.Add("ActiveUsers", ActiveUsers.ToResoniteReference(context));
members.Add("IsHost", IsHost.ToResoniteReference(context));
members.Add("AwayKickEnabled", AwayKickEnabled.ToResoniteReference(context));
members.Add("AwayKickInterval", AwayKickInterval.ToResoniteReference(context));
}

}
}
