
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatistics+SessionStats
// Generated on: pátek 13. února 2026 5:51:10
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
    public partial class OnlineStatistics
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OnlineStatistics+SessionStats")]
public partial class SessionStats : global::FrooxEngine.SyncObject

{
    public global::System.Nullable<global::System.Int32> PublicSessions;
public global::System.Nullable<global::System.Int32> RegisteredSessions;
public global::System.Nullable<global::System.Int32> ContactsPlusSessions;
public global::System.Nullable<global::System.Int32> ContactsSessions;
public global::System.Nullable<global::System.Int32> LANSessions;
public global::System.Nullable<global::System.Int32> PrivateSessions;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PublicSessions", PublicSessions.ToResoniteLinkField());
members.Add("RegisteredSessions", RegisteredSessions.ToResoniteLinkField());
members.Add("ContactsPlusSessions", ContactsPlusSessions.ToResoniteLinkField());
members.Add("ContactsSessions", ContactsSessions.ToResoniteLinkField());
members.Add("LANSessions", LANSessions.ToResoniteLinkField());
members.Add("PrivateSessions", PrivateSessions.ToResoniteLinkField());
}

}
            }
}
