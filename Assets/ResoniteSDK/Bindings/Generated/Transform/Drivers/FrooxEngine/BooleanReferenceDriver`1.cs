
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanReferenceDriver<>
// Generated on: sobota 14. února 2026 8:58:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanReferenceDriver<>")]
public partial class BooleanReferenceDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::System.Boolean State;
public global::FrooxEngine.SyncRef<T> TargetReference;
public T FalseTarget;
public T TrueTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State.ToResoniteLinkField());
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("FalseTarget", FalseTarget.ToResoniteReference(context));
members.Add("TrueTarget", TrueTarget.ToResoniteReference(context));
}

}
}
