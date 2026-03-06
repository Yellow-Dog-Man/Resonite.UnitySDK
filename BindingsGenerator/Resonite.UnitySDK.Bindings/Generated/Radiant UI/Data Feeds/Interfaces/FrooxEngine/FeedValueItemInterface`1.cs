
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedValueItemInterface<>
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedValueItemInterface<>")]
public abstract partial class FeedValueItemInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Value_Element = new();
public global::FrooxEngine.IField<global::System.String> Formatting { get => Formatting_Element.Data; set => Formatting_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Formatting_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("Formatting", Formatting_Element.ToLinkReference(context));
}

}
}
