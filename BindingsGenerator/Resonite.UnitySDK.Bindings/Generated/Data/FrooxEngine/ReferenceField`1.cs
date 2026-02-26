
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceField<>
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceField<>")]
public partial class ReferenceField<T> : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<T>, global::FrooxEngine.IReferenceSource
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
}

}
}
