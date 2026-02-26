
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceMultiplexer<>
// Generated on: čtvrtek 26. února 2026 15:09:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceMultiplexer<>")]
public partial class ReferenceMultiplexer<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>> Target_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<T>, T, Reference<global::FrooxEngine.SyncRef<T>, T>> References = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Index", Index_Element.ToLinkField(context));
members.Add("References", References.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("AllowWriteBack", AllowWriteBack_Element.ToLinkField(context));
}

}
}
