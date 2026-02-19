
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrioritySyncRefList<>+ListItem
// Generated on: čtvrtek 19. února 2026 7:59:43
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
    public partial class PrioritySyncRefList<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrioritySyncRefList<>+ListItem")]
public partial class ListItem : global::FrooxEngine.SyncObject

{
    public T Target;
public global::System.Int32 Priority;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Priority", Priority.ToResoniteLinkField());
}

}
            }
}
