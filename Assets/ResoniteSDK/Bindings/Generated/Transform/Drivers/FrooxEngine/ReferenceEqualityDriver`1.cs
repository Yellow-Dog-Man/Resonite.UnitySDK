
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceEqualityDriver<>
// Generated on: sobota 14. února 2026 8:58:39
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.SyncRef<T> TargetReference;
public T Reference;
public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::System.Boolean Invert;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Invert", Invert.ToResoniteLinkField());
}

}
}
