
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrioritySyncRefList<>+ListItem
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
    public partial class PrioritySyncRefList<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrioritySyncRefList<>+ListItem")]
public partial class ListItem : global::FrooxEngine.SyncObject

{
    public T Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Target_Element = new();
public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Priority", Priority_Element.ToLinkField(context));
}

}
            }
}
