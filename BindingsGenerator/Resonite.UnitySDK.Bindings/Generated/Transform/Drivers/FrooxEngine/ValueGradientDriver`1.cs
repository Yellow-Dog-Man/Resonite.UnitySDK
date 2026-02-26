
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueGradientDriver<>
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueGradientDriver<>")]
public partial class ValueGradientDriver<T> : global::FrooxEngine.Component
	

{
    public global::System.Single Progress { get => Progress_Element.Data; set => Progress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Progress_Element = new();
public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Target_Element = new();
public global::System.Boolean Interpolate { get => Interpolate_Element.Data; set => Interpolate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Interpolate_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ValueGradientDriver<T>.Point>, global::FrooxEngine.ValueGradientDriver<T>.Point> Points = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress_Element.ToLinkField(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Interpolate", Interpolate_Element.ToLinkField(context));
members.Add("Points", Points.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
