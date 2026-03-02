
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PriorityEntry<>
// Generated on: pondělí 2. března 2026 17:53:33
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PriorityEntry<>")]
public partial class PriorityEntry<K> : global::FrooxEngine.PriorityEntry
	

{
    public K EntryID { get => EntryID_Element.Data; set => EntryID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<K>, K> EntryID_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EntryID", EntryID_Element.ToLinkField(context));
}

}
}
