
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedClampedValueFieldInterface<>")]
public partial class FeedClampedValueFieldInterface<T> : global::FrooxEngine.FeedValueItemInterface<T>
	

{
    public global::FrooxEngine.IField<T> Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Min_Element = new();
public global::FrooxEngine.IField<T> Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Max_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Min", Min_Element.ToLinkReference(context));
members.Add("Max", Max_Element.ToLinkReference(context));
}

}
}
