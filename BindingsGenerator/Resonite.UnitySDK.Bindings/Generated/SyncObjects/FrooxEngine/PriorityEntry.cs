
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PriorityEntry
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PriorityEntry")]
public abstract partial class PriorityEntry : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Priority;
public global::System.Boolean IsFirst;
public global::System.Boolean IsLast;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("IsFirst", IsFirst.ToResoniteLinkField());
members.Add("IsLast", IsLast.ToResoniteLinkField());
}

}
}
