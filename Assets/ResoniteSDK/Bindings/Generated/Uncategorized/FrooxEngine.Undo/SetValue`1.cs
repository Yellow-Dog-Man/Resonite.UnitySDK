
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetValue<>
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetValue<>")]
public partial class SetValue<T> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	

{
    public global::FrooxEngine.IField<T> Target;
public T ValueBefore;
public T ValueAfter;
public global::System.Boolean _performed;
public global::System.String _description;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("ValueBefore", ValueBefore.ToResoniteLinkField());
members.Add("ValueAfter", ValueAfter.ToResoniteLinkField());
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}
