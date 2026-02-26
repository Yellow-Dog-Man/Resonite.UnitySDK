
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedValueActionInterface<>
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedValueActionInterface<>")]
public partial class FeedValueActionInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.SyncDelegate<global::System.Action<T>> Action { get => Action_Element.Data; set => Action_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action<T>>>, global::FrooxEngine.SyncDelegate<global::System.Action<T>>> Action_Element = new();
public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Value_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Highlight { get => Highlight_Element.Data; set => Highlight_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Highlight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Action", Action_Element.ToLinkReference(context));
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("Highlight", Highlight_Element.ToLinkReference(context));
}

}
}
