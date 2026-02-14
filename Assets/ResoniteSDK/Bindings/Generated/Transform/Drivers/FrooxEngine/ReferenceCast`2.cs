
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceCast<,>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceCast<,>")]
public partial class ReferenceCast<I,O> : global::FrooxEngine.Component
	where O : class, global::FrooxEngine.IWorldElement
	where I : class, global::FrooxEngine.IWorldElement

{
    public I Source;
public global::FrooxEngine.SyncRef<O> Target;
public global::System.Boolean WriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}
