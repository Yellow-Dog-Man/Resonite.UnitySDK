
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OnlineStatistics+SessionStats
// Generated on: čtvrtek 26. února 2026 12:26:52
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
    public partial class OnlineStatistics
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OnlineStatistics+SessionStats")]
public partial class SessionStats : global::FrooxEngine.SyncObject

{
    public global::System.Nullable<global::System.Int32> PublicSessions { get => PublicSessions_Element.Data; set => PublicSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> PublicSessions_Element = new();
public global::System.Nullable<global::System.Int32> RegisteredSessions { get => RegisteredSessions_Element.Data; set => RegisteredSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> RegisteredSessions_Element = new();
public global::System.Nullable<global::System.Int32> ContactsPlusSessions { get => ContactsPlusSessions_Element.Data; set => ContactsPlusSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> ContactsPlusSessions_Element = new();
public global::System.Nullable<global::System.Int32> ContactsSessions { get => ContactsSessions_Element.Data; set => ContactsSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> ContactsSessions_Element = new();
public global::System.Nullable<global::System.Int32> LANSessions { get => LANSessions_Element.Data; set => LANSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> LANSessions_Element = new();
public global::System.Nullable<global::System.Int32> PrivateSessions { get => PrivateSessions_Element.Data; set => PrivateSessions_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> PrivateSessions_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PublicSessions", PublicSessions_Element.ToLinkField(context));
members.Add("RegisteredSessions", RegisteredSessions_Element.ToLinkField(context));
members.Add("ContactsPlusSessions", ContactsPlusSessions_Element.ToLinkField(context));
members.Add("ContactsSessions", ContactsSessions_Element.ToLinkField(context));
members.Add("LANSessions", LANSessions_Element.ToLinkField(context));
members.Add("PrivateSessions", PrivateSessions_Element.ToLinkField(context));
}

}
            }
}
