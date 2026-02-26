
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrioritySyncRefList<>
// Generated on: čtvrtek 26. února 2026 12:27:26
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrioritySyncRefList<>")]
public partial class PrioritySyncRefList<T> : global::FrooxEngine.SyncObject
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.PrioritySyncRefList<T>.ListItem>, global::FrooxEngine.PrioritySyncRefList<T>.ListItem> Items = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Items", Items.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
