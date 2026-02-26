
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceList<>
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceList<>")]
public partial class ReferenceList<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<T>, T, Field<global::FrooxEngine.SyncRef<T>, T>> References = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("References", References.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
