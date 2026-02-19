
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetReference<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetReference<>")]
public partial class SetReference<T> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public T TargetBefore;
public T TargetAfter;
public global::System.Boolean _performed;
public global::System.String _description;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("TargetBefore", TargetBefore.ToResoniteReference(context));
members.Add("TargetAfter", TargetAfter.ToResoniteReference(context));
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}
