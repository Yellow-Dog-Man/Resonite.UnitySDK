
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrioritySyncRefList<>
// Generated on: středa 25. února 2026 16:13:38
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrioritySyncRefList<>")]
public partial class PrioritySyncRefList<T> : global::FrooxEngine.SyncObject
	where T : class, global::FrooxEngine.IWorldElement

{
    public System.Collections.Generic.List<global::FrooxEngine.PrioritySyncRefList<T>.ListItem> Items;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
