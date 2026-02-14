
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentReferenceLink<>
// Generated on: sobota 14. února 2026 8:57:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParentReferenceLink<>")]
public partial class ParentReferenceLink<T> : global::FrooxEngine.ParentDataLink<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target;
public global::System.Boolean WriteBack;
public T DefaultReference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("DefaultReference", DefaultReference.ToResoniteReference(context));
}

}
}
