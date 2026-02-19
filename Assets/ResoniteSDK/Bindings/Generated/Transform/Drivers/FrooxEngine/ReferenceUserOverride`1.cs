
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceUserOverride<>
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceUserOverride<>")]
public partial class ReferenceUserOverride<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public T Default;
public global::System.Boolean CreateOverrideOnWrite;
public global::System.Boolean PersistentOverrides;
public global::System.Boolean ClearOnUserLeave;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Default", Default.ToResoniteReference(context));
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite.ToResoniteLinkField());
members.Add("PersistentOverrides", PersistentOverrides.ToResoniteLinkField());
members.Add("ClearOnUserLeave", ClearOnUserLeave.ToResoniteLinkField());
}

}
}
