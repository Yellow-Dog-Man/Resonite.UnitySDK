
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface+NestedItem
// Generated on: čtvrtek 26. února 2026 15:09:01
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
    public partial class FeedItemInterface
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedItemInterface+NestedItem")]
public partial class NestedItem : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FeedItemInterface Interface { get => Interface_Element.Data; set => Interface_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FeedItemInterface>, global::FrooxEngine.FeedItemInterface> Interface_Element = new();
public global::FrooxEngine.Slot Container { get => Container_Element.Data; set => Container_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Container_Element = new();
public global::System.Boolean IgnoreParentContainer { get => IgnoreParentContainer_Element.Data; set => IgnoreParentContainer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreParentContainer_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Interface", Interface_Element.ToLinkReference(context));
members.Add("Container", Container_Element.ToLinkReference(context));
members.Add("IgnoreParentContainer", IgnoreParentContainer_Element.ToLinkField(context));
}

}
            }
}
