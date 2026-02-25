
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatistics+SessionStats
// Generated on: středa 25. února 2026 16:13:06
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
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
