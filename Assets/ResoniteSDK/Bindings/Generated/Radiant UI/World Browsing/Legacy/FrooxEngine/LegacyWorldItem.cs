
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldItem
// Generated on: pátek 13. února 2026 23:23:02
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldItem")]
public abstract partial class LegacyWorldItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef UpdatingUser;
public global::System.String WorldOrSessionId;
public global::System.Boolean _visited;
public global::System.Int32 _totalActiveUsers;
public global::System.Int32 _totalContacts;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers() });
members.Add("WorldOrSessionId", WorldOrSessionId.ToResoniteLinkField());
members.Add("_visited", _visited.ToResoniteLinkField());
members.Add("_totalActiveUsers", _totalActiveUsers.ToResoniteLinkField());
members.Add("_totalContacts", _totalContacts.ToResoniteLinkField());
}

}
}
