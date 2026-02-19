
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldItem
// Generated on: čtvrtek 19. února 2026 8:00:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldItem")]
public abstract partial class LegacyWorldItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef UpdatingUser;
public global::System.String WorldOrSessionId;
public global::System.Boolean _visited;
public global::System.Int32 _totalActiveUsers;
public global::System.Int32 _totalContacts;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers(context) });
members.Add("WorldOrSessionId", WorldOrSessionId.ToResoniteLinkField());
members.Add("_visited", _visited.ToResoniteLinkField());
members.Add("_totalActiveUsers", _totalActiveUsers.ToResoniteLinkField());
members.Add("_totalContacts", _totalContacts.ToResoniteLinkField());
}

}
}
