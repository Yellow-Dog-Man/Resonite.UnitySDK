
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldItemInterface
// Generated on: pátek 13. února 2026 5:52:19
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("WorldName", new ResoniteLink.Reference() { });
members.Add("Description", new ResoniteLink.Reference() { });
members.Add("ThumbnailUrl", new ResoniteLink.Reference() { });
members.Add("JoinedUsers", new ResoniteLink.Reference() { });
members.Add("ActiveUsers", new ResoniteLink.Reference() { });
members.Add("IsHost", new ResoniteLink.Reference() { });
members.Add("AwayKickEnabled", new ResoniteLink.Reference() { });
members.Add("AwayKickInterval", new ResoniteLink.Reference() { });
}

}
}
