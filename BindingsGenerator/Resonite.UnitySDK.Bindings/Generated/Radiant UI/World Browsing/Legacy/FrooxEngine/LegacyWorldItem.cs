
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldItem
// Generated on: čtvrtek 26. února 2026 15:09:02
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UserRef UpdatingUser = new();
public global::System.String WorldOrSessionId { get => WorldOrSessionId_Element.Data; set => WorldOrSessionId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> WorldOrSessionId_Element = new();
public global::System.Boolean _visited { get => _visited_Element.Data; set => _visited_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _visited_Element = new();
public global::System.Int32 _totalActiveUsers { get => _totalActiveUsers_Element.Data; set => _totalActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _totalActiveUsers_Element = new();
public global::System.Int32 _totalContacts { get => _totalContacts_Element.Data; set => _totalContacts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _totalContacts_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdatingUser", UpdatingUser.ToLinkSyncObject(context));
members.Add("WorldOrSessionId", WorldOrSessionId_Element.ToLinkField(context));
members.Add("_visited", _visited_Element.ToLinkField(context));
members.Add("_totalActiveUsers", _totalActiveUsers_Element.ToLinkField(context));
members.Add("_totalContacts", _totalContacts_Element.ToLinkField(context));
}

}
}
