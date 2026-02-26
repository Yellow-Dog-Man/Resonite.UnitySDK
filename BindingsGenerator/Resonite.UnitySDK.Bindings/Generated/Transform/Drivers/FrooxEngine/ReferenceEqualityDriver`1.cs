
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceEqualityDriver<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceEqualityDriver<>")]
public partial class ReferenceEqualityDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncRef<T>>, global::FrooxEngine.SyncRef<T>> TargetReference_Element = new();
public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Reference_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Target_Element = new();
public global::System.Boolean Invert { get => Invert_Element.Data; set => Invert_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Invert_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
members.Add("Reference", Reference_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Invert", Invert_Element.ToLinkField(context));
}

}
}
